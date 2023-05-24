using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment_System_Ptoject
{
    [Serializable]
     public class Manager : Worker
    {
        public string _username { get; set; }
        public string _password { get; set; }

        public Manager(string username = "no_name", string password = "-123456789",
                       string firstName = "no_name", string lastName = "no_name",
                       double salary = 0.0, string phoneNumber = "no_phone_number",
                       string mail = "no_mail", DateTime employmentDate = new DateTime(),
                       DateTime dateOfBirth = new DateTime(), string gender = "no_gender",
                         string department = "Manager", ImageWithTag managerImg = null)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._phoneNumber = phoneNumber;
            this._employmentDate = employmentDate;
            this._department = department;
            this._dateOfBirth = dateOfBirth;
            this._gender = gender;
            this._username = username;
            this._password = password;
            this._mail = mail;
            this._workerImg = managerImg;
            this._salary = salary;
        }

        public string getUsername() { return this._username; }
        public void setUsername(string username) { this._username = username; }
        public string getPassword() { return this._password; }
        public void setPassword(string pass) { this._password = pass; }
        public override double getSalary() { return this._salary * 0.75; }


    }
}
