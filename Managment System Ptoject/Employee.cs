using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment_System_Ptoject
{
    [Serializable]
    public class Employee : Worker
    {
        public int _accountNumber { get; set; }
        public int _hoursPerDay { get; set; }
        public string _address { get; set; }
        public Employee(string firstName = "no_name", string lastName = "no_name", double salary = 0.0,
            string phoneNumber = "no_phone_number", DateTime employmentDate = new DateTime(),
            string department = "no_department", DateTime dateOfBirth = new DateTime(),
            string gender = "no_gender", string mail = "no_mail", int accountNumber = -1
            , int hoursPerDay = 0, string address = "no_address", ImageWithTag empImg = null)
        {
            this._accountNumber = accountNumber;
            this._hoursPerDay = hoursPerDay;
            this._address = address;
            this._firstName = firstName;
            this._lastName = lastName;
            this._phoneNumber = phoneNumber;
            this._employmentDate = employmentDate;
            this._department = department;
            this._dateOfBirth = dateOfBirth;
            this._gender = gender;
            this._mail = mail;
            this._workerImg = empImg;
            this._salary = salary;
        }

        public int getAccountNumber() { return this._accountNumber; }
        public void setAccountNumber(int accountNumber) { this._accountNumber = accountNumber; }

        public int getHoursPerDay() { return this._hoursPerDay; }
        public void setHoursPerDay(int hourPerDay) { this._hoursPerDay = hourPerDay; }
        public string getAddress() { return this._address; }
        public void setAddress(string address) { this._address = address; }
        public override double getSalary() { return this._salary*0.83; }
        public override double calculateHourlyWage()
        {
            return getSalary() / (_hoursPerDay * 5);
        }




    }


}
