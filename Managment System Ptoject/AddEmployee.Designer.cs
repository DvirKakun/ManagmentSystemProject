
namespace Managment_System_Ptoject
{
    partial class AddEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.hoursPerDay = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.accountNumber = new System.Windows.Forms.TextBox();
            this.department = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.dateOfEmployment = new System.Windows.Forms.DateTimePicker();
            this.dateOfEmploymentLbl = new System.Windows.Forms.Label();
            this.dateOfBirthLbl = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.genderLbl = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.ComboBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.employeeImg = new System.Windows.Forms.PictureBox();
            this.chooseImgBtn = new System.Windows.Forms.Button();
            this.dropHere = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeImg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.hoursPerDay);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.accountNumber);
            this.groupBox1.Controls.Add(this.department);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.dateOfEmployment);
            this.groupBox1.Controls.Add(this.dateOfEmploymentLbl);
            this.groupBox1.Controls.Add(this.dateOfBirthLbl);
            this.groupBox1.Controls.Add(this.dateOfBirth);
            this.groupBox1.Controls.Add(this.genderLbl);
            this.groupBox1.Controls.Add(this.gender);
            this.groupBox1.Controls.Add(this.salary);
            this.groupBox1.Controls.Add(this.phoneNumber);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.lastName);
            this.groupBox1.Controls.Add(this.firstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 621);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(336, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 21);
            this.label8.TabIndex = 40;
            this.label8.Text = "Address";
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.LightGray;
            this.address.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address.ForeColor = System.Drawing.Color.DimGray;
            this.address.Location = new System.Drawing.Point(352, 411);
            this.address.Name = "address";
            this.address.PlaceholderText = "Address";
            this.address.Size = new System.Drawing.Size(274, 28);
            this.address.TabIndex = 9;
            this.address.Leave += new System.EventHandler(this.address_Leave);
            // 
            // hoursPerDay
            // 
            this.hoursPerDay.BackColor = System.Drawing.Color.LightGray;
            this.hoursPerDay.DisplayMember = "Management";
            this.hoursPerDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hoursPerDay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hoursPerDay.ForeColor = System.Drawing.Color.DimGray;
            this.hoursPerDay.FormattingEnabled = true;
            this.hoursPerDay.Items.AddRange(new object[] {
            "1",
            "10",
            "11",
            "12",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.hoursPerDay.Location = new System.Drawing.Point(535, 484);
            this.hoursPerDay.Name = "hoursPerDay";
            this.hoursPerDay.Size = new System.Drawing.Size(62, 29);
            this.hoursPerDay.Sorted = true;
            this.hoursPerDay.TabIndex = 12;
            this.hoursPerDay.Leave += new System.EventHandler(this.hoursPerDay_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(494, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 21);
            this.label7.TabIndex = 37;
            this.label7.Text = "Hours Pre Day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 21);
            this.label6.TabIndex = 35;
            this.label6.Text = "Account Number";
            // 
            // accountNumber
            // 
            this.accountNumber.BackColor = System.Drawing.Color.LightGray;
            this.accountNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accountNumber.ForeColor = System.Drawing.Color.DimGray;
            this.accountNumber.Location = new System.Drawing.Point(42, 411);
            this.accountNumber.Name = "accountNumber";
            this.accountNumber.PlaceholderText = "Account Number";
            this.accountNumber.Size = new System.Drawing.Size(274, 28);
            this.accountNumber.TabIndex = 8;
            this.accountNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accountNumber_KeyPress);
            this.accountNumber.Leave += new System.EventHandler(this.accountNumber_Leave);
            // 
            // department
            // 
            this.department.BackColor = System.Drawing.Color.LightGray;
            this.department.DisplayMember = "Management";
            this.department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.department.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.department.ForeColor = System.Drawing.Color.DimGray;
            this.department.FormattingEnabled = true;
            this.department.Items.AddRange(new object[] {
            "Cleaning",
            "Finance",
            "Maintenance",
            "Resources"});
            this.department.Location = new System.Drawing.Point(346, 342);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(274, 29);
            this.department.Sorted = true;
            this.department.TabIndex = 7;
            this.department.Leave += new System.EventHandler(this.department_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(330, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Department";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(26, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "First Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(336, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Salary";
            // 
            // addBtn
            // 
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Location = new System.Drawing.Point(190, 560);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(254, 42);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dateOfEmployment
            // 
            this.dateOfEmployment.CalendarMonthBackground = System.Drawing.Color.SkyBlue;
            this.dateOfEmployment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateOfEmployment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfEmployment.Location = new System.Drawing.Point(272, 485);
            this.dateOfEmployment.MinDate = new System.DateTime(1923, 1, 1, 0, 0, 0, 0);
            this.dateOfEmployment.Name = "dateOfEmployment";
            this.dateOfEmployment.Size = new System.Drawing.Size(211, 28);
            this.dateOfEmployment.TabIndex = 11;
            // 
            // dateOfEmploymentLbl
            // 
            this.dateOfEmploymentLbl.AutoSize = true;
            this.dateOfEmploymentLbl.BackColor = System.Drawing.Color.Transparent;
            this.dateOfEmploymentLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateOfEmploymentLbl.ForeColor = System.Drawing.Color.Black;
            this.dateOfEmploymentLbl.Location = new System.Drawing.Point(272, 461);
            this.dateOfEmploymentLbl.Name = "dateOfEmploymentLbl";
            this.dateOfEmploymentLbl.Size = new System.Drawing.Size(212, 21);
            this.dateOfEmploymentLbl.TabIndex = 17;
            this.dateOfEmploymentLbl.Text = "Date Of Employement :";
            this.dateOfEmploymentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateOfBirthLbl
            // 
            this.dateOfBirthLbl.AutoSize = true;
            this.dateOfBirthLbl.BackColor = System.Drawing.Color.Transparent;
            this.dateOfBirthLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateOfBirthLbl.ForeColor = System.Drawing.Color.Black;
            this.dateOfBirthLbl.Location = new System.Drawing.Point(78, 461);
            this.dateOfBirthLbl.Name = "dateOfBirthLbl";
            this.dateOfBirthLbl.Size = new System.Drawing.Size(135, 21);
            this.dateOfBirthLbl.TabIndex = 16;
            this.dateOfBirthLbl.Text = "Date Of Birth :";
            this.dateOfBirthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.CalendarMonthBackground = System.Drawing.Color.SkyBlue;
            this.dateOfBirth.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirth.Location = new System.Drawing.Point(42, 485);
            this.dateOfBirth.MaxDate = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(211, 28);
            this.dateOfBirth.TabIndex = 10;
            this.dateOfBirth.Value = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.BackColor = System.Drawing.Color.Transparent;
            this.genderLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genderLbl.ForeColor = System.Drawing.Color.Black;
            this.genderLbl.Location = new System.Drawing.Point(346, 245);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(87, 21);
            this.genderLbl.TabIndex = 14;
            this.genderLbl.Text = "Gender :";
            this.genderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.Color.LightGray;
            this.gender.DisplayMember = "Management";
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gender.ForeColor = System.Drawing.Color.DimGray;
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.gender.Location = new System.Drawing.Point(346, 269);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(274, 29);
            this.gender.Sorted = true;
            this.gender.TabIndex = 5;
            this.gender.Leave += new System.EventHandler(this.gender_Leave);
            // 
            // salary
            // 
            this.salary.BackColor = System.Drawing.Color.LightGray;
            this.salary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salary.ForeColor = System.Drawing.Color.DimGray;
            this.salary.Location = new System.Drawing.Point(42, 343);
            this.salary.Name = "salary";
            this.salary.PlaceholderText = "Salary";
            this.salary.Size = new System.Drawing.Size(274, 28);
            this.salary.TabIndex = 6;
            this.salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salary_KeyPress);
            this.salary.Leave += new System.EventHandler(this.salary_Leave);
            // 
            // phoneNumber
            // 
            this.phoneNumber.BackColor = System.Drawing.Color.LightGray;
            this.phoneNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumber.ForeColor = System.Drawing.Color.DimGray;
            this.phoneNumber.Location = new System.Drawing.Point(42, 269);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.PlaceholderText = "Phone Number";
            this.phoneNumber.Size = new System.Drawing.Size(274, 28);
            this.phoneNumber.TabIndex = 4;
            this.phoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumber_KeyPress);
            this.phoneNumber.Leave += new System.EventHandler(this.phoneNumber_Leave);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.LightGray;
            this.email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.ForeColor = System.Drawing.Color.DimGray;
            this.email.Location = new System.Drawing.Point(42, 195);
            this.email.Name = "email";
            this.email.PlaceholderText = "Email";
            this.email.Size = new System.Drawing.Size(578, 28);
            this.email.TabIndex = 3;
            this.email.Leave += new System.EventHandler(this.email_Leave);
            // 
            // lastName
            // 
            this.lastName.BackColor = System.Drawing.Color.LightGray;
            this.lastName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastName.ForeColor = System.Drawing.Color.DimGray;
            this.lastName.Location = new System.Drawing.Point(346, 120);
            this.lastName.Name = "lastName";
            this.lastName.PlaceholderText = "Last Name";
            this.lastName.Size = new System.Drawing.Size(274, 27);
            this.lastName.TabIndex = 2;
            this.lastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastName_KeyPress);
            this.lastName.Leave += new System.EventHandler(this.lastName_Leave);
            // 
            // firstName
            // 
            this.firstName.BackColor = System.Drawing.Color.LightGray;
            this.firstName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstName.ForeColor = System.Drawing.Color.DimGray;
            this.firstName.Location = new System.Drawing.Point(42, 120);
            this.firstName.Name = "firstName";
            this.firstName.PlaceholderText = "First Name";
            this.firstName.Size = new System.Drawing.Size(274, 27);
            this.firstName.TabIndex = 1;
            this.firstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstName_KeyPress);
            this.firstName.Leave += new System.EventHandler(this.firstName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Employee";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Managment_System_Ptoject.Properties.Resources.addEmployee;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(651, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 304);
            this.panel1.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // employeeImg
            // 
            this.employeeImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.employeeImg.Location = new System.Drawing.Point(651, 47);
            this.employeeImg.Name = "employeeImg";
            this.employeeImg.Size = new System.Drawing.Size(549, 275);
            this.employeeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employeeImg.TabIndex = 3;
            this.employeeImg.TabStop = false;
            this.employeeImg.DragDrop += new System.Windows.Forms.DragEventHandler(this.employeeImg_DragDrop);
            this.employeeImg.DragEnter += new System.Windows.Forms.DragEventHandler(this.employeeImg_DragEnter);
            // 
            // chooseImgBtn
            // 
            this.chooseImgBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseImgBtn.Location = new System.Drawing.Point(842, 12);
            this.chooseImgBtn.Name = "chooseImgBtn";
            this.chooseImgBtn.Size = new System.Drawing.Size(162, 29);
            this.chooseImgBtn.TabIndex = 13;
            this.chooseImgBtn.Text = "Upload image";
            this.chooseImgBtn.UseVisualStyleBackColor = true;
            this.chooseImgBtn.Click += new System.EventHandler(this.chooseImgBtn_Click);
            // 
            // dropHere
            // 
            this.dropHere.AutoSize = true;
            this.dropHere.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dropHere.Location = new System.Drawing.Point(856, 177);
            this.dropHere.Name = "dropHere";
            this.dropHere.Size = new System.Drawing.Size(90, 23);
            this.dropHere.TabIndex = 14;
            this.dropHere.Text = "Drop Here";
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearBtn.Location = new System.Drawing.Point(1106, 12);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(94, 29);
            this.clearBtn.TabIndex = 15;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1212, 663);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.dropHere);
            this.Controls.Add(this.chooseImgBtn);
            this.Controls.Add(this.employeeImg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1230, 710);
            this.MinimumSize = new System.Drawing.Size(1230, 710);
            this.Name = "AddEmployee";
            this.Text = "Add Employee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DateTimePicker dateOfEmployment;
        private System.Windows.Forms.Label dateOfEmploymentLbl;
        private System.Windows.Forms.Label dateOfBirthLbl;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox accountNumber;
        private System.Windows.Forms.ComboBox hoursPerDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox employeeImg;
        private System.Windows.Forms.Button chooseImgBtn;
        private System.Windows.Forms.Label dropHere;
        private System.Windows.Forms.Button clearBtn;
    }
}