using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Managment_System_Ptoject
{
    public partial class EditEmployee : Form
    {
        int index;
        Worker worker;
        Employee emp;
        Manager mng;
        public EditEmployee(int value)
        {
            InitializeComponent();
            employeeImg.AllowDrop = true;
            index = value;
            worker = (Worker)Program.myCompany._myCompanyList[index];
            firstName.Text = worker._firstName;
            lastName.Text = worker._lastName;
            email.Text = worker._mail;
            phoneNumber.Text = worker._phoneNumber;
            gender.Text = worker._gender;
            salary.Text = worker._salary.ToString();
            department.Text = worker._department;
            dateOfBirth.Value = worker._dateOfBirth;
            dateOfEmployment.Value = worker._employmentDate;
            employeeImg.Image = worker._workerImg.Image;
            employeeImg.Image.Tag = worker._workerImg.Tag;
            if (Program.myCompany._myCompanyList[index] is Employee)
            {
                emp = (Employee)Program.myCompany._myCompanyList[index];
                address.Text = emp._address;
                hoursPerDay.Text = emp._hoursPerDay.ToString();
                accountNumber.Text = emp._accountNumber.ToString();
            }
            if (Program.myCompany._myCompanyList[index] is Manager)
            {
                mng = (Manager)Program.myCompany._myCompanyList[index];
                username.Visible = true;
                password.Visible = true;
                usernameLbl.Visible = true;
                passwordLbl.Visible = true;
                departmentLbl.Visible = false;
                department.Visible = false;
                accountNumberLbl.Visible = false;
                accountNumber.Visible = false;
                hoursPerDayLbl.Visible = false;
                hoursPerDay.Visible = false;
                addressLbl.Visible = false;
                address.Visible = false;
                showPassword.Visible = true;
                username.Text = mng._username;
                password.Text = mng._password;
            }

        }

        private void firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8) // 8 = backspace
            {
                e.Handled = true;
            }
        }

        private void lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8) // 8 = backspace
            {
                e.Handled = true;
            }
        }

        private bool isLegalEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, pattern);
        }
        private int checkIfMailIsExist(string mail)
        {
            foreach (Worker obj in Program.myCompany._myCompanyList)
            {
                if (obj.getMail().Equals(mail))
                {
                    return 1;
                }
            }
            return 0;
        }

        private int isLegalPassword(string password)
        {
            int i;
            int upperCounter = 0;
            int lowerCounter = 0;
            int len = password.Length;
            for (i = 0; i < len; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    upperCounter = 1;
                }
                if (char.IsLower(password[i]))
                {
                    lowerCounter = 1;
                }
            }
            return lowerCounter & upperCounter;

        }
        private int checkIfUsernameExist(string username)
        {
            foreach (Worker obj in Program.myCompany._myCompanyList)
            {
                if (obj is Manager)
                {
                    Manager mng = (Manager)(obj);
                    if (mng.getUsername().Equals(username))
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = !password.UseSystemPasswordChar;
        }
        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Visible == true)
            {
                if (username.Text == "")
                {
                    errorProvider1.SetError(this.username, "Username cannot be empty !");
                    return;
                }
                else if (!username.Text.Equals(mng._username) && checkIfUsernameExist(username.Text) == 1)
                {
                    errorProvider1.SetError(this.username, "Username is already exist !");
                }
                else
                    errorProvider1.Clear();
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Visible == true)
            {
                if (password.Text == "")
                {
                    errorProvider1.SetError(this.password, "Password cannot be empty !");
                }
                else if (password.TextLength < 8)
                {
                    errorProvider1.SetError(this.password, "Password must contain 8 values !");
                }
                else if (isLegalPassword(password.Text) == 0)
                {
                    errorProvider1.SetError(this.password, "Password must contain 1 uppercase letter and 1 lowercase letter");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
        }
        private void email_Leave(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                errorProvider1.SetError(this.email, "Email cannot be empty !");
            }
            else if (isLegalEmail(email.Text) == false)
            {
                errorProvider1.SetError(this.email, "Ilegal email !");
            }
            else if (!email.Text.Equals(worker._mail) && checkIfMailIsExist(email.Text) == 1)
            {
                errorProvider1.SetError(this.email, "Email is already exist");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void firstName_Leave(object sender, EventArgs e)
        {
            if (firstName.Text == "")
            {
                errorProvider1.SetError(this.firstName, "First Name cannot be empty !");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void lastName_Leave(object sender, EventArgs e)
        {
            if (lastName.Text == "")
            {
                errorProvider1.SetError(this.lastName, "Last Name cannot be empty !");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == '\b')
            {
                return;
            }
            if (!char.IsNumber(ch) && !char.IsControl(ch) || phoneNumber.Text.Length >= 10)
            {
                e.Handled = true;
            }
        }

        private void phoneNumber_Leave(object sender, EventArgs e)
        {
            if (phoneNumber.Text == "")
            {
                errorProvider1.SetError(this.phoneNumber, "Phone Number cannot be empty !");
            }
            else if (phoneNumber.Text.Length < 10)
            {
                errorProvider1.SetError(this.phoneNumber, "Phone Number must contain 10 digits !");
            }
            else if (phoneNumber.Text[0] != '0' || phoneNumber.Text[1] != '5')
            {
                errorProvider1.SetError(this.phoneNumber, "Ilegal Phone Number");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void gender_Leave(object sender, EventArgs e)
        {
            if (gender.Text == "")
            {
                errorProvider1.SetError(this.gender, "Gender cannot be empty !");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == '.' && (salary.Text == "" || salary.Text.IndexOf(ch) != -1))
            {
                e.Handled = true;
                return;
            }
            if (ch != '.' && !char.IsDigit(ch) && !char.IsControl(ch))
            {
                e.Handled = true;
            }
        }

        private void salary_Leave(object sender, EventArgs e)
        {
            if (salary.Text == "")
            {
                errorProvider1.SetError(this.salary, "Salary cannot be empty !");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void address_Leave(object sender, EventArgs e)
        {
            if (address.Visible == true)
            {
                if (address.Text == "")
                {
                    errorProvider1.SetError(this.address, "Address cannot be empty !");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
        }

        private void hoursPerDay_Leave(object sender, EventArgs e)
        {
            if (hoursPerDay.Visible == true)
            {
                if (hoursPerDay.Text == "")
                {
                    errorProvider1.SetError(this.hoursPerDay, "Hours Per Day cannot be empty !");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
        }

        private void department_Leave(object sender, EventArgs e)
        {
            if (department.Visible == true)
            {
                if (department.Text == "")
                {
                    errorProvider1.SetError(this.department, "Department cannot be empty !");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
        }

        private void accountNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
                char ch = e.KeyChar;
                if (ch == '\b')
                {
                    return;
                }
                if (!char.IsNumber(ch) && !char.IsControl(ch))
                {
                    e.Handled = true;
                }
        }

        private void accountNumber_Leave(object sender, EventArgs e)
        {
            if (accountNumber.Visible == true)
            {
                if (phoneNumber.Text == "")
                {
                    errorProvider1.SetError(this.phoneNumber, "Phone Number cannot be empty !");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
        }

        private void chooseImgBtn_Click(object sender, EventArgs e)
        {
            string imagePath = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = "C:\\";
            dialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = dialog.FileName;
                employeeImg.Image = Image.FromFile(imagePath); 
                employeeImg.Image.Tag = "special";
            }
        }

        private void gender_TextChanged(object sender, EventArgs e)
        {
            if (employeeImg.Image != null)
            {
                if (gender.Text.Equals("Male") && (employeeImg.Image.Tag.Equals("female")))
                {
                    employeeImg.Image = Properties.Resources.maleEmpIcon;
                    employeeImg.Image.Tag = "male";
                }
                else if (gender.Text.Equals("Female") && (employeeImg.Image.Tag.Equals("male")))
                {
                    employeeImg.Image = Properties.Resources.femaleEmpIcon;
                    employeeImg.Image.Tag = "female";
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            bool isErrorActive = false;
            foreach (Control c in this.groupBox1.Controls)
            {
                if (errorProvider1.GetError(c).Length > 0)  //check if error is active
                {
                    isErrorActive = true;
                }
            }
            if (username.Visible == true && string.IsNullOrEmpty(username.Text))
            {
                errorProvider1.SetError(this.firstName, "First Name cannot be empty !");
            }
            if (password.Visible == true && string.IsNullOrEmpty(password.Text))
            {
                errorProvider1.SetError(this.firstName, "First Name cannot be empty !");
            }
            if (string.IsNullOrEmpty(firstName.Text))
            {
                errorProvider1.SetError(this.firstName, "First Name cannot be empty !");
            }
            else if (string.IsNullOrEmpty(lastName.Text))
            {
                errorProvider1.SetError(this.lastName, "Last Name cannot be empty !");
            }
            else if (string.IsNullOrEmpty(email.Text))
            {
                errorProvider1.SetError(this.email, "Email cannot be empty !");
            }
            else if (string.IsNullOrEmpty(phoneNumber.Text))
            {
                errorProvider1.SetError(this.phoneNumber, "Phone Number cannot be empty !");
            }
            else if (string.IsNullOrEmpty(salary.Text))
            {
                errorProvider1.SetError(this.salary, "Salary cannot be empty !");
            }
            else if (department.Visible == true && string.IsNullOrEmpty(department.Text))
            {
                errorProvider1.SetError(this.department, "Department cannot be empty !");
            }
            else if (string.IsNullOrEmpty(gender.Text))
            {
                errorProvider1.SetError(this.gender, "Gender cannot be empty !");
            }
            else if (hoursPerDay.Visible == true && string.IsNullOrEmpty(hoursPerDay.Text))
            {
                errorProvider1.SetError(this.gender, "Hours Per Day cannot be empty !");
            }
            else if (address.Visible == true && string.IsNullOrEmpty(address.Text))
            {
                errorProvider1.SetError(this.gender, "Address cannot be empty !");
            }
            else if (accountNumber.Visible == true && string.IsNullOrEmpty(accountNumber.Text))
            {
                errorProvider1.SetError(this.gender, "Account Number cannot be empty !");
            }
            else
            {
                if (isErrorActive == false)
                {
                    DialogResult result = MessageBox.Show("Are you sure ?", "Edit Employee", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        worker._firstName = firstName.Text;
                        worker._lastName = lastName.Text;
                        worker._mail = email.Text;
                        worker._phoneNumber = phoneNumber.Text;
                        worker._gender = gender.Text;
                        worker._salary = double.Parse(salary.Text);
                        if(department.Visible == true)
                           worker._department = department.Text;
                        worker._dateOfBirth = dateOfBirth.Value;
                        worker._employmentDate = dateOfEmployment.Value;
                        worker._workerImg.Image = employeeImg.Image;
                        worker._workerImg.Tag = employeeImg.Image.Tag;
                        if (Program.myCompany._myCompanyList[index] is Employee)
                        {
                            ((Employee)(worker))._accountNumber = int.Parse(accountNumber.Text);
                            ((Employee)(worker))._address = address.Text;
                            ((Employee)(worker))._hoursPerDay = int.Parse(hoursPerDay.Text);
                            Program.myCompany._myCompanyList[index] = (Employee)(worker);
                        }
                        else if (Program.myCompany._myCompanyList[index] is Manager)
                        {
                            ((Manager)(worker))._username = username.Text;
                            ((Manager)(worker))._password = password.Text;
                            Program.myCompany._myCompanyList[index] = (Manager)(worker);
                        }
                        IFormatter formatter = new BinaryFormatter();
                        using (Stream stream = new FileStream("myListFile", FileMode.Create, FileAccess.Write, FileShare.None))
                        {
                            formatter.Serialize(stream, Program.myCompany._myCompanyList);
                        }
                        PopupNotifier popup = new PopupNotifier();
                        popup.Image = Properties.Resources.V;
                        popup.ImageSize = new Size(100, 100);
                        popup.TitleText = "Edit Employee";
                        popup.TitleFont = new Font("Imprint MT Shadow", 14);
                        popup.ContentText = "Employee Edited Successfully";
                        popup.ContentFont = new Font("Arial Rounded MT", 10);
                        popup.Popup();
                        ViewForm.instance.EmployesTable.Refresh();
                        this.Hide();
                    }
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
            }
        }

        private void employeeImg_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    employeeImg.Image = Image.FromFile(fileNames[0]);
                    employeeImg.Image.Tag = "special";
                }
            }
        }

        private void employeeImg_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (employeeImg.Image.Tag.ToString().Equals("special"))
            {
                if (gender.Text.Equals("Male"))
                {
                    employeeImg.Image = Properties.Resources.maleEmpIcon;
                    employeeImg.Image.Tag = "male";
                }
                else
                {
                    employeeImg.Image = Properties.Resources.femaleEmpIcon;
                    employeeImg.Image.Tag = "female";
                }
            }
        }
    }
}
