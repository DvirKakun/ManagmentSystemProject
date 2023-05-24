using System;
using System.Windows.Forms;
using System.Drawing;
namespace Managment_System_Ptoject
{
    [Serializable]
    public class Worker // base class - Worker
    {
        public int _serialNumber { get; set; }
        public string _firstName { get; set; }
        public string _lastName { get; set; }
        public string _gender { get; set; }
        public string _phoneNumber { get; set; }
        public string _mail { get; set; }
        public DateTime _dateOfBirth { get; set; }
        public DateTime _employmentDate { get; set; }
        public string _department { get; set; }
        public double _salary { get; set; }
        public ImageWithTag _workerImg { get; set; }
        //all the members in the constructor get default values because we create polymorphic list of 
        //workers that can get employee/manager so at the moment we build employee/manager
        //we automaticlly build in the background worker object so we must have empty 
        //constructor or constructor that get default values.
        public Worker(string firstName = "no_name", string lastName = "no_name",
                      double salary = 0.0, string phoneNumber = "no_phone_number", string mail = "no_mail",
                      DateTime employmentDate = new DateTime(), string department = "no_deparment",
                      DateTime dateOfBirth = new DateTime(), string gender = "no_gender", ImageWithTag workerImg = null)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._phoneNumber = phoneNumber;
            this._employmentDate = employmentDate;
            this._department = department;
            this._dateOfBirth = dateOfBirth;
            this._gender = gender;
            this._mail = mail;
            this._workerImg = workerImg;
            this._salary = salary;
            }
        
        public string getFirstName() { return this._firstName; }
        public void setFirstName(string firstName) { this._firstName = firstName; }
        public string getLastName() { return this._lastName; }
        public void setLastName(string lastName) { this._lastName = lastName; }
        public virtual double getSalary() { return this._salary; }
        public  void setSalary(double salary) { this._salary = salary; }
        public string getPhoneNumber() { return this._phoneNumber; }
        public void setPhoneNumber(string phoneNumber) { this._phoneNumber = phoneNumber; }
        public DateTime getEmploymentDate() { return this._employmentDate; }
        public void setEmploymentDate(DateTime employmentDate) { this._employmentDate = employmentDate; }
        public int getSerialNumber() { return this._serialNumber; }
        public void setSerialNumber(int serialNumber) { this._serialNumber= serialNumber; }
        public string getDeparment() { return this._department; }
        public void setDeprment(string deparment) { this._department = deparment; }
        public DateTime getDateOfBirth() { return this._dateOfBirth; }
        public void setDateOfBirth(DateTime dateOfBirth) { this._dateOfBirth = dateOfBirth; }
        public string getGender() { return this._gender; }
        public void setGender(string gender) { this._gender = gender; }
        public string getMail() { return this._mail; }
        public void setMail(string mail) { this._mail = mail; }

        public virtual double calculateHourlyWage()
        {
            return -1;
        }

    }
}