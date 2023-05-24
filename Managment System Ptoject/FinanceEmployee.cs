using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment_System_Ptoject
{
    [Serializable]
    public class FinanceEmployee : Employee
    {
        public FinanceEmployee(string firstName, string lastName, double salary,
                               string phoneNumber, DateTime employmentDate, string department,
                               DateTime dateOfBirth, string gender, string mail, int accountNumber,
                               int hoursPerDay, string address, ImageWithTag fncImg)
        {
            this._accountNumber = accountNumber;
            this._hoursPerDay = hoursPerDay;
            this._address = address;
            this._firstName = firstName;
            this._lastName = lastName;
            this._salary = salary;
            this._phoneNumber = phoneNumber;
            this._employmentDate = employmentDate;
            this._department = department;
            this._dateOfBirth = dateOfBirth;
            this._gender = gender;
            this._mail = mail;
            this._workerImg = fncImg;
        }
        public override double getSalary() { return this._salary * 0.85; }
    }
}
