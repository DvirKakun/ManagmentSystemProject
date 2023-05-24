using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managment_System_Ptoject
{
    public partial class EmployeeReport : Form
    {
        int index;
        double hourlyW;
        public EmployeeReport(int value)
        {
            InitializeComponent();
            index = value;
            buildReport(index);
        }
        private void buildReport(int index)
        {
            this.firstNameLbl.Text = Program.myCompany._myCompanyList[index]._firstName;
            this.lastNameLbl.Text = Program.myCompany._myCompanyList[index]._lastName;
            this.employeeNameLbl.Text = this.firstNameLbl.Text + " " + this.lastNameLbl.Text;
            this.serialNumberLbl.Text = Program.myCompany._myCompanyList[index]._serialNumber.ToString();
            this.genderLbl.Text = Program.myCompany._myCompanyList[index]._gender;
            this.departmentLbl.Text = Program.myCompany._myCompanyList[index]._department;
            this.phoneNumberLbl.Text = Program.myCompany._myCompanyList[index]._phoneNumber;
            this.mailLbl.Text = Program.myCompany._myCompanyList[index]._mail;
            this.salaryLbl.Text = Program.myCompany._myCompanyList[index].getSalary().ToString("0.00");
            this.dateOfBirthLbl.Text = Program.myCompany._myCompanyList[index]._dateOfBirth.ToString();
            this.dateOfEmploymentLbl.Text = Program.myCompany._myCompanyList[index]._employmentDate.ToString();
            this.workerPicture.Image = Program.myCompany._myCompanyList[index]._workerImg.Image;
            hourlyW = Program.myCompany._myCompanyList[index].calculateHourlyWage();
            if(hourlyW != -1)
            {
                this.hourlyWageLbl.Text = hourlyW.ToString("0.00");
            }
            if (Program.myCompany._myCompanyList[index] is Manager)
            {
                Manager mng = (Manager)(Program.myCompany._myCompanyList[index]);
                usernameLbl.Text = mng._username;
                passwordLbl.Text = mng._password;

                username.Visible = true;
                usernameLbl.Visible = true;

                password.Visible = true;
                passwordLbl.Visible = true;
            }
            else if(Program.myCompany._myCompanyList[index] is Employee)
            {
                Employee emp = (Employee)(Program.myCompany._myCompanyList[index]);
                addressLbl.Text = emp._address;
                accountNumberLbl.Text = emp._accountNumber.ToString();
                hoursPerDayLbl.Text = emp._hoursPerDay.ToString();

                address.Visible = true;
                addressLbl.Visible = true;

                accountNumber.Visible = true;
                accountNumberLbl.Visible = true;

                hoursPerDay.Visible = true;
                hoursPerDayLbl.Visible = true;

                hourlyWage.Visible = true;
                hourlyWageLbl.Visible = true;
            }
        }

    }
}
