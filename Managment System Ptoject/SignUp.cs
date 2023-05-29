using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using Tulpep.NotificationWindow;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Formatters.Binary;

namespace Managment_System_Ptoject
{
    public partial class SignUp : Form
    { 

        public SignUp()
        {
            InitializeComponent();
            managerImg.AllowDrop = true;
        }
        
        private int isLegalPassword(string password) //check if the password stands for the requriements
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
        private bool isLegalEmail(string email) //check if the mail stands for the requriements
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, pattern);
        }
        private int checkIfUsernameExist(string username) //check if the username is exist in the file
        {
            if (File.Exists("myListFile") == false)
            {
                return 0;
            }
            foreach(Worker obj in Program.myCompany._myCompanyList)
            {
                if (obj is Manager) {
                    Manager mng = (Manager)(obj);
                    if (mng.getUsername().Equals(username))
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }
        private int checkIfMailIsExist(string mail) //check if mail is exist in the file
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

        private void phoneNumber_KeyPress(object sender, KeyPressEventArgs e) //ensure that the pressed key is a number and the length of the number is 10
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

        private void salary_KeyPress(object sender, KeyPressEventArgs e) //ensure that the pressed key is a number and the salary contains maximun 1 dot
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

        private void showPassword_CheckedChanged(object sender, EventArgs e) 
        {
            password.UseSystemPasswordChar = !password.UseSystemPasswordChar;
            confirmPassword.UseSystemPasswordChar = !confirmPassword.UseSystemPasswordChar;
        }

        private void firstName_Leave(object sender, EventArgs e) //check if the text is empty when leaving the textBox
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

        private void lastName_Leave(object sender, EventArgs e) //check if the text is empty when leaving the textBox
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

        private void firstName_KeyPress(object sender, KeyPressEventArgs e) //check if the pressed key is a char
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8) // 8 = backspace
            {
                e.Handled = true;
            }
        }

        private  void username_Leave(object sender, EventArgs e) //check if the text is empty or the username is exist
        {
            if (username.Text == "")
            {
                errorProvider1.SetError(this.username, "Username cannot be empty !");
                return;
            }
            else if (checkIfUsernameExist(username.Text) == 1)
            {
                errorProvider1.SetError(this.username, "Username is already exist !");
            }
            else
                 errorProvider1.Clear();
        }

        private void password_Leave(object sender, EventArgs e)
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

        private void confirmPassword_Leave(object sender, EventArgs e)
        {
            if(confirmPassword.Text == "")
            {
                errorProvider1.SetError(this.confirmPassword, "Confirm password cannot be empty !");
            }
            else if (!confirmPassword.Text.Equals(password.Text))
            {
                errorProvider1.SetError(this.confirmPassword, "Passwords do not match !");
            }
            else
            {
                errorProvider1.Clear();

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
            else if (checkIfMailIsExist(email.Text) == 1)
            {
                errorProvider1.SetError(this.email, "Email is already exist");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void confirmEmail_Leave(object sender, EventArgs e)
        {
            if(confirmEmail.Text == "")
            {
                errorProvider1.SetError(this.confirmEmail, "Confirm email cannot be empty !");
            }
            else if (!confirmEmail.Text.Equals(email.Text))
            {
                errorProvider1.SetError(this.confirmEmail, "Emails do not match !");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
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
            else if (string.IsNullOrEmpty(username.Text))
            {
                errorProvider1.SetError(this.username, "Username cannot be empty !");
            }
            else if (string.IsNullOrEmpty(password.Text))
            {
                errorProvider1.SetError(this.password, "Password cannot be empty !");
            }
            else if (string.IsNullOrEmpty(confirmPassword.Text))
            {
                errorProvider1.SetError(this.confirmPassword, "Confirm Password cannot be empty !");
            }
            else if (string.IsNullOrEmpty(email.Text))
            {
                errorProvider1.SetError(this.email, "Email cannot be empty !");
            }
            else if (string.IsNullOrEmpty(confirmEmail.Text))
            {
                errorProvider1.SetError(this.confirmEmail, "Confirm Email cannot be empty !");
            }
            else if (string.IsNullOrEmpty(phoneNumber.Text))
            {
                errorProvider1.SetError(this.phoneNumber, "Phone Number cannot be empty !");
            }
            else if (string.IsNullOrEmpty(salary.Text))
            {
                errorProvider1.SetError(this.salary, "Salary cannot be empty !");
            }
            else if (string.IsNullOrEmpty(managerCode.Text))
            {
                errorProvider1.SetError(this.managerCode, "Manager Code cannot be empty !");
            }
            else if (string.IsNullOrEmpty(gender.Text))
            {
                errorProvider1.SetError(this.gender, "Gender cannot be empty !");
            }
            else
            {
                if (isErrorActive == false)
                {
                    imageValidation imv = new imageValidation();
                    DialogResult ImgValidationResult = imv.ShowDialog();
                    if (ImgValidationResult == DialogResult.OK)
                    {
                        DialogResult result = MessageBox.Show("Are you sure ?", "Sign up", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            ImageWithTag managerIm = new ImageWithTag();
                            if (managerImg.Image == null)
                            {
                                managerIm.Image = Properties.Resources.managerIcon;
                                managerIm.Tag = "manager";
                            }
                            else
                            {
                                managerIm.Image = managerImg.Image;
                                managerIm.Tag = "special";
                            }
                            DateTime dof = dateOfBirth.Value;
                            DateTime doe = dateOfEmployment.Value;
                            Manager mng = new Manager(username.Text, password.Text, firstName.Text, lastName.Text,
                                                     double.Parse(salary.Text), phoneNumber.Text, email.Text,
                                                     doe, dof, gender.Text, "Manager", managerIm);
                            Program.myCompany.AddWorker(mng);
                            IFormatter formatter = new BinaryFormatter();
                            using (Stream stream = new FileStream("myListFile", FileMode.Create, FileAccess.Write, FileShare.None))
                            {
                                formatter.Serialize(stream, Program.myCompany._myCompanyList);
                            }
                            PopupNotifier popup = new PopupNotifier();
                            popup.Image = Properties.Resources.V;
                            popup.ImageSize = new Size(100, 100);
                            popup.TitleText = "Sign Up";
                            popup.TitleFont = new Font("Imprint MT Shadow", 14);
                            popup.ContentText = "Sign Up Successfully";
                            popup.ContentFont = new Font("Arial Rounded MT", 10);
                            popup.Popup();
                            this.Hide();
                            LoginScreen login = new LoginScreen();
                            login.Show();
                        }
                        if (result == DialogResult.No)
                        {
                            return;
                        }
                    }
                }

            }
        }
        private void phoneNumber_Leave(object sender, EventArgs e)
        {
            if(phoneNumber.Text == "")
            {
                errorProvider1.SetError(this.phoneNumber, "Phone Number cannot be empty !");
            }
            else if(phoneNumber.Text.Length < 10)
            {
                errorProvider1.SetError(this.phoneNumber, "Phone Number must contain 10 digits !");
            }
            else if(phoneNumber.Text[0] != '0' || phoneNumber.Text[1]!= '5')
            {
                errorProvider1.SetError(this.phoneNumber, "Ilegal Phone Number");
            }
            else
            {
                errorProvider1.Clear();
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

        private void managerCode_Leave(object sender, EventArgs e)
        {
            if (managerCode.Text == "")
            {
                errorProvider1.SetError(this.managerCode, "Manager Code cannot be empty !");
            }
            else if (managerCode.Text != "HIpVb37Ane8Iy79j3SjxA1V5kgLqYGEKLw2lBLOy")
            {
                errorProvider1.SetError(this.managerCode, "Invalid Manager Code !");
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

        private void lgnButton_Click(object sender, EventArgs e)
        {
            LoginScreen lgn = new LoginScreen();
            this.Hide();
            lgn.Show();
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void uploadImgBtn_Click(object sender, EventArgs e) //upload image button
        {
            string imagePath = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = "C:\\";
            dialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = dialog.FileName;
                managerImg.Image = Image.FromFile(imagePath);
                dropHere.Visible = false;
            }
        }

        private void managerImg_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if(data != null)
            {
                var fileNames = data as string[];
                if(fileNames.Length > 0)
                {
                    managerImg.Image = Image.FromFile(fileNames[0]);
                    dropHere.Visible = false;
                }
            }
        }

        private void managerImg_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            managerImg.Image = null;
            dropHere.Visible = true;
        }
    }
}
