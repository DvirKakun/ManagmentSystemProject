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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            employeeImg.AllowDrop = true;
            int x;
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
            if (File.Exists("myListFile") == false)
            {
                return 0;
            }
            foreach (Worker obj in Program.myCompany._myCompanyList)
            {
                if (obj.getMail().Equals(mail))
                {
                    return 1;
                }
            }
            return 0;
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
            else if (checkIfMailIsExist(email.Text) == 1)
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
            if (address.Text == "")
            {
                errorProvider1.SetError(this.address, "Address cannot be empty !");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void hoursPerDay_Leave(object sender, EventArgs e)
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

        private void department_Leave(object sender, EventArgs e)
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            bool isErrorActive = false;
            foreach (Control c in this.groupBox1.Controls)
            {
                if (errorProvider1.GetError(c).Length > 0)  //check if error is active
                {
                    isErrorActive = true;
                }
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
            else if (string.IsNullOrEmpty(department.Text))
            {
                errorProvider1.SetError(this.department, "Department cannot be empty !");
            }
            else if (string.IsNullOrEmpty(gender.Text))
            {
                errorProvider1.SetError(this.gender, "Gender cannot be empty !");
            }
            else if (string.IsNullOrEmpty(hoursPerDay.Text))
            {
                errorProvider1.SetError(this.hoursPerDay, "Hours Per Day cannot be empty !");
            }
            else if (string.IsNullOrEmpty(address.Text))
            {
                errorProvider1.SetError(this.address, "Address cannot be empty !");
            }
            else if (string.IsNullOrEmpty(accountNumber.Text))
            {
                errorProvider1.SetError(this.accountNumber, "Account Number cannot be empty !");
            }
            else
            {
                if (isErrorActive == false)
                {
                    DialogResult result = MessageBox.Show("Are you sure ?", "Add Employe", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        ImageWithTag employeeIm = new ImageWithTag();
                        if (employeeImg.Image == null)
                        {
                            if (gender.Text.Equals("Male"))
                            {
                                employeeIm.Image = Properties.Resources.maleEmpIcon;
                                employeeIm.Tag = "male";
                            }
                            else
                            {
                                employeeIm.Image = Properties.Resources.femaleEmpIcon;
                                employeeIm.Tag = "female";

                            }
                        }
                        else
                        {
                            employeeIm.Image = employeeImg.Image;
                            employeeIm.Tag = "special";
                        }
                        DateTime dob = dateOfBirth.Value;
                        DateTime doe = dateOfEmployment.Value;
                        if (department.Text.Equals(("Resources")))
                        {
                            ResourcesEmployee rsc = new ResourcesEmployee(firstName.Text, lastName.Text,
                                                                         double.Parse(salary.Text), phoneNumber.Text, doe
                                                                         , department.Text, dob, gender.Text, email.Text
                                                                          , int.Parse(accountNumber.Text), int.Parse(hoursPerDay.Text), address.Text, employeeIm);
                            Program.myCompany.AddWorker(rsc);
                        }
                        else if (department.Text.Equals("Cleaning"))
                        {
                            CleaningEmployee cln = new CleaningEmployee(firstName.Text, lastName.Text,
                                                                      double.Parse(salary.Text), phoneNumber.Text, doe
                                                                      , department.Text, dob, gender.Text, email.Text
                                                                       , int.Parse(accountNumber.Text), int.Parse(hoursPerDay.Text), address.Text, employeeIm);
                            Program.myCompany.AddWorker(cln);
                        }
                        else if (department.Text.Equals("Finance"))
                        {
                            FinanceEmployee fnc = new FinanceEmployee(firstName.Text, lastName.Text,
                                                                      double.Parse(salary.Text), phoneNumber.Text, doe
                                                                      , department.Text, dob, gender.Text, email.Text
                                                                       , int.Parse(accountNumber.Text), int.Parse(hoursPerDay.Text), address.Text, employeeIm);
                            Program.myCompany.AddWorker(fnc);
                        }
                        else if (department.Text.Equals("Maintenance"))
                        {
                            MaintenanceEmployee rsc = new MaintenanceEmployee(firstName.Text, lastName.Text,
                                                                      double.Parse(salary.Text), phoneNumber.Text, doe
                                                                      , department.Text, dob, gender.Text, email.Text
                                                                       , int.Parse(accountNumber.Text), int.Parse(hoursPerDay.Text), address.Text, employeeIm);
                            Program.myCompany.AddWorker(rsc);
                        }

                        IFormatter formatter = new BinaryFormatter();
                        using (Stream stream = new FileStream("myListFile", FileMode.Create, FileAccess.Write, FileShare.None))
                        {
                            formatter.Serialize(stream, Program.myCompany._myCompanyList);
                        }
                        PopupNotifier popup = new PopupNotifier();
                        popup.Image = Properties.Resources.V;
                        popup.ImageSize = new Size(100, 100);
                        popup.TitleText = "Add Employee";
                        popup.TitleFont = new Font("Imprint MT Shadow", 14);
                        popup.ContentText = "Employee Added Successfully";
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
            if (phoneNumber.Text == "")
            {
                errorProvider1.SetError(this.phoneNumber, "Phone Number cannot be empty !");
            }
            else
            {
                errorProvider1.Clear();
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
                dropHere.Visible = false;
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
                    dropHere.Visible = false;
                }
            }
        }

        private void employeeImg_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            employeeImg.Image = null;
            dropHere.Visible = true;
        }
    }
}
