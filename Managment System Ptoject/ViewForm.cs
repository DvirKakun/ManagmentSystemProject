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
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Managment_System_Ptoject
{
    public partial class ViewForm : Form
    {
        PopupNotifier popup = new PopupNotifier();
        public static ViewForm instance { get; private set; }
        public ViewForm()
        {
            InitializeComponent();
            constructTable();
            instance = this;
            popup.ImageSize = new Size(100, 100);
            popup.TitleFont = new Font("Imprint MT Shadow", 14); //popup set
            popup.ContentFont = new Font("Arial Rounded MT", 10);

        } 
        public void constructTable()
        {
            EmployesTable.DataSource = Program.myCompany._myCompanyList; //set the data source of the Table as the worker's list
            EmployesTable.Columns["_firstName"].HeaderCell.Value = "First Name";
            EmployesTable.Columns["_lastName"].HeaderCell.Value = "Last Name";
            EmployesTable.Columns["_phoneNumber"].HeaderCell.Value = "Phone Number";
            EmployesTable.Columns["_mail"].HeaderCell.Value = "Mail";
            EmployesTable.Columns["_dateOfBirth"].HeaderCell.Value = "Date Of Birth";
            EmployesTable.Columns["_employmentDate"].HeaderCell.Value = "Date Of Employment";
            EmployesTable.Columns["_gender"].HeaderCell.Value = "Gender";
            EmployesTable.Columns["_department"].HeaderCell.Value = "Department";
            EmployesTable.Columns["_salary"].HeaderCell.Value = "Gross Salary";
            EmployesTable.Columns["_serialNumber"].HeaderCell.Value = "Serial Number";
            EmployesTable.Columns.Remove("_workerImg");
            EmployesTable.AutoGenerateColumns = false;
            EmployesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            LoginScreen lgs = new LoginScreen();
            this.Hide();
            lgs.Show();
        }

        private void ViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private string choiceString(string choose) //return the actual name of the column
        {
            string myChoice = "";
            if (choose.Equals("First Name"))
            {
                myChoice = "_firstName";
            }
            if (choose.Equals("Last Name"))
            {
                myChoice = "_lastName";
            }
            if (choose.Equals("Serial Number"))
            {
                myChoice = "_serialNumber";
            }
            if (choose.Equals("Phone Number"))
            {
                myChoice = "_phoneNumber";
            }
            return myChoice;

        }
        private void searchTbx_KeyDown(object sender, KeyEventArgs e) //check if the pressed key is Enter and activate search, if the search text is empty or the "search by" text is empty do not activate the search
        {
            if(e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(searchChoice.Text) && !string.IsNullOrEmpty(searchTbx.Text))
            {
                string choice = searchChoice.Text;
                choice = choiceString(choice);
                EmployesTable.ClearSelection();
                foreach (DataGridViewRow dgr in EmployesTable.Rows)
                {
                    foreach (DataGridViewCell dgc in dgr.Cells)
                    {
                        string text = "";
                        if (dgc.OwningColumn.Name.Equals(choice))
                        {
                            text += dgc.Value.ToString();
                            if (text.ToUpper().Contains(searchTbx.Text.ToUpper()))
                            {
                                dgr.Selected = true;
                                break;
                            }
                        }
                    }
                }
                if (EmployesTable.SelectedRows.Count == 0) //is the string doesn't match anything nothing will be selected
                {
                    popup.Image = Properties.Resources.X;
                    popup.TitleText = "Search";
                    popup.ContentText = "Employee doesn't exist";
                    popup.Popup();
                }
            }
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            AddEmployee ademp = new AddEmployee();
            ademp.Show();
        }

        private void removeEmployeeBtn_Click(object sender, EventArgs e)
        {
            int serialNumber;
            popup.TitleText = "Remove";
            if (EmployesTable.SelectedRows.Count == 0)
            {
                popup.Image = Properties.Resources.info;
                popup.ContentText = "Please choose an employee";
                popup.Popup();
                return;
            }
            foreach (DataGridViewRow dgr in EmployesTable.SelectedRows)
            {
                if (dgr.Cells["_department"].Value.ToString().Equals("Manager")) //show error if you are trying to remove a Manager
                {
                    popup.Image = Properties.Resources.X;
                    popup.ContentText = "Manager Cannot Be Deleted";
                    popup.Popup();
                    return;
                }
            }

            DialogResult result = MessageBox.Show("Are you sure ?", "Remove Employee", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow dgr in EmployesTable.SelectedRows)
                {
                    serialNumber = int.Parse(dgr.Cells["_serialNumber"].Value.ToString());
                    Program.myCompany.RemoveWorker(serialNumber);
                    EmployesTable.Refresh();
                }
                popup.Image = Properties.Resources.V;
                popup.ContentText = "Employee Removed Successfully";
                popup.Popup();

                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream("myListFile", FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(stream, Program.myCompany._myCompanyList);
                }
            }
            else
                return;

        }

        private void EmployesTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) //double click on a specific cell and show the employee report
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                EmployeeReport er = new EmployeeReport(index);
                er.Show();
            }
        }

        private void editEmployeeBtn_Click(object sender, EventArgs e)
        {
            popup.TitleText = "Edit";
            if (EmployesTable.SelectedRows.Count == 0)
            {
                popup.Image = Properties.Resources.X;
                popup.ContentText = "Please choose an employee";
                popup.Popup();
                return;
            }
            else if (EmployesTable.SelectedRows.Count > 1)
            {
                popup.Image = Properties.Resources.X;
                popup.ContentText = "You can't choose multiple employees";
                popup.Popup();
                return;
            }
            int index = EmployesTable.SelectedCells[0].RowIndex;
            EditEmployee ede = new EditEmployee(index);
            ede.Show();
        }
    }
}
