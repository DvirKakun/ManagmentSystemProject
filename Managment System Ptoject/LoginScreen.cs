using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Managment_System_Ptoject
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private int checkIfUsernameExist(string username)//check if username exists in the file
        {
            if (File.Exists("myListFile") == false)
            {
                return 0;
            }
            foreach (Worker obj in Program.myCompany._myCompanyList)//run over the workers in the list
            {
                if(obj is Manager) //check if the worker type is actually manager type
                {
                    Manager mng = (Manager)obj; //create manager type object from the worker obj
                    if (mng.getUsername().Equals(username))//check if the mng username is equal to the username
                    {
                        return 1;
                    }
                }

            }
            return 0;
        }

        private int checkIfPasswordExist(string username , string password)//check if password exists in the file
        {
            if (File.Exists("myListFile") == false)
            {
                return 0;
            }
            foreach (Worker obj in Program.myCompany._myCompanyList)
            {
                if (obj is Manager)
                {
                    Manager mng = (Manager)obj;
                    if (mng.getUsername().Equals(username))
                    {
                        if (mng.getPassword().Equals(password)) //check if the mng password is equal to password
                        {
                            return 1;
                        }
                    }
                }
            }
            return 0;
        }
        private void showPassword_CheckedChanged(object sender, EventArgs e)// event - what happend every change of selection
        {
            password.UseSystemPasswordChar = !password.UseSystemPasswordChar; //enable and unable the hidden password format
        }

        private void loginBtn_Click(object sender, EventArgs e)//event - what happend every click on the loginBtn
        {
           if(username.Text == "")//if username is empty set error on the textBox 
            {
                errorProvider1.SetError(username, "Username cannot be empty !");
            }
           else if(password.Text == "")//if password is empty set error on the textBox 
            {
                errorProvider1.SetError(password, "Password cannot be empty !");
            }
           else if(checkIfUsernameExist(username.Text) == 1)
            {
                if(checkIfPasswordExist(username.Text,password.Text) == 1)//if the username and the password match
                {
                    PopupNotifier popup = new PopupNotifier();//build new PopupNotifier
                    popup.Image = Properties.Resources.V;//put image in the popup
                    popup.ImageSize = new Size(100, 100);//determine the size
                    popup.TitleText = "Login";//title text
                    popup.TitleFont = new Font("Imprint MT Shadow", 14);//title font
                    popup.ContentText = "Login Successfully";//content text
                    popup.ContentFont = new Font("Arial Rounded MT", 10);//contect font
                    popup.Popup();
                    this.Hide();
                    ViewForm view = new ViewForm();
                    view.Show();
                }
                else
                {
                    errorProvider1.SetError(password, "Password invalid !");
                }
            }
            else
            {
                errorProvider1.SetError(username, "Username is invalid !");

            }
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp sgu = new SignUp();
            sgu.Show();
        }

        private void LoginScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
