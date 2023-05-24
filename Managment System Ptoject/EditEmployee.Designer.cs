
namespace Managment_System_Ptoject
{
    partial class EditEmployee
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
            this.chooseImgBtn = new System.Windows.Forms.Button();
            this.employeeImg = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.addressLbl = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.hoursPerDay = new System.Windows.Forms.ComboBox();
            this.hoursPerDayLbl = new System.Windows.Forms.Label();
            this.accountNumberLbl = new System.Windows.Forms.Label();
            this.accountNumber = new System.Windows.Forms.TextBox();
            this.department = new System.Windows.Forms.ComboBox();
            this.departmentLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.phoneNumberLbl = new System.Windows.Forms.Label();
            this.salaryLbl = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeImg)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseImgBtn
            // 
            this.chooseImgBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseImgBtn.Location = new System.Drawing.Point(842, 15);
            this.chooseImgBtn.Name = "chooseImgBtn";
            this.chooseImgBtn.Size = new System.Drawing.Size(162, 29);
            this.chooseImgBtn.TabIndex = 16;
            this.chooseImgBtn.Text = "Upload image";
            this.chooseImgBtn.UseVisualStyleBackColor = true;
            this.chooseImgBtn.Click += new System.EventHandler(this.chooseImgBtn_Click);
            // 
            // employeeImg
            // 
            this.employeeImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.employeeImg.Location = new System.Drawing.Point(651, 50);
            this.employeeImg.Name = "employeeImg";
            this.employeeImg.Size = new System.Drawing.Size(549, 275);
            this.employeeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employeeImg.TabIndex = 7;
            this.employeeImg.TabStop = false;
            this.employeeImg.DragDrop += new System.Windows.Forms.DragEventHandler(this.employeeImg_DragDrop);
            this.employeeImg.DragEnter += new System.Windows.Forms.DragEventHandler(this.employeeImg_DragEnter);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Managment_System_Ptoject.Properties.Resources.addEmployee;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(651, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 381);
            this.panel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.showPassword);
            this.groupBox1.Controls.Add(this.passwordLbl);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.usernameLbl);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.addressLbl);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.hoursPerDay);
            this.groupBox1.Controls.Add(this.hoursPerDayLbl);
            this.groupBox1.Controls.Add(this.accountNumberLbl);
            this.groupBox1.Controls.Add(this.accountNumber);
            this.groupBox1.Controls.Add(this.department);
            this.groupBox1.Controls.Add(this.departmentLbl);
            this.groupBox1.Controls.Add(this.firstNameLbl);
            this.groupBox1.Controls.Add(this.lastNameLbl);
            this.groupBox1.Controls.Add(this.emailLbl);
            this.groupBox1.Controls.Add(this.phoneNumberLbl);
            this.groupBox1.Controls.Add(this.salaryLbl);
            this.groupBox1.Controls.Add(this.editBtn);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 698);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Leave += new System.EventHandler(this.address_Leave);
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showPassword.ForeColor = System.Drawing.Color.Black;
            this.showPassword.Location = new System.Drawing.Point(352, 591);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(173, 25);
            this.showPassword.TabIndex = 15;
            this.showPassword.Text = "Show password";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.Visible = false;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLbl.ForeColor = System.Drawing.Color.Black;
            this.passwordLbl.Location = new System.Drawing.Point(330, 533);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(98, 21);
            this.passwordLbl.TabIndex = 44;
            this.passwordLbl.Text = "Password";
            this.passwordLbl.Visible = false;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.LightGray;
            this.password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.ForeColor = System.Drawing.Color.DimGray;
            this.password.Location = new System.Drawing.Point(343, 557);
            this.password.Name = "password";
            this.password.PlaceholderText = "Password";
            this.password.Size = new System.Drawing.Size(274, 28);
            this.password.TabIndex = 14;
            this.password.UseSystemPasswordChar = true;
            this.password.Visible = false;
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLbl.ForeColor = System.Drawing.Color.Black;
            this.usernameLbl.Location = new System.Drawing.Point(26, 533);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(102, 21);
            this.usernameLbl.TabIndex = 42;
            this.usernameLbl.Text = "Username";
            this.usernameLbl.Visible = false;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.LightGray;
            this.username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username.ForeColor = System.Drawing.Color.DimGray;
            this.username.Location = new System.Drawing.Point(42, 557);
            this.username.Name = "username";
            this.username.PlaceholderText = "Username";
            this.username.Size = new System.Drawing.Size(274, 28);
            this.username.TabIndex = 13;
            this.username.Visible = false;
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressLbl.ForeColor = System.Drawing.Color.Black;
            this.addressLbl.Location = new System.Drawing.Point(336, 387);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(84, 21);
            this.addressLbl.TabIndex = 40;
            this.addressLbl.Text = "Address";
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
            this.hoursPerDay.Location = new System.Drawing.Point(535, 488);
            this.hoursPerDay.Name = "hoursPerDay";
            this.hoursPerDay.Size = new System.Drawing.Size(62, 29);
            this.hoursPerDay.Sorted = true;
            this.hoursPerDay.TabIndex = 12;
            this.hoursPerDay.Leave += new System.EventHandler(this.hoursPerDay_Leave);
            // 
            // hoursPerDayLbl
            // 
            this.hoursPerDayLbl.AutoSize = true;
            this.hoursPerDayLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hoursPerDayLbl.ForeColor = System.Drawing.Color.Black;
            this.hoursPerDayLbl.Location = new System.Drawing.Point(494, 465);
            this.hoursPerDayLbl.Name = "hoursPerDayLbl";
            this.hoursPerDayLbl.Size = new System.Drawing.Size(139, 21);
            this.hoursPerDayLbl.TabIndex = 37;
            this.hoursPerDayLbl.Text = "Hours Pre Day";
            // 
            // accountNumberLbl
            // 
            this.accountNumberLbl.AutoSize = true;
            this.accountNumberLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accountNumberLbl.ForeColor = System.Drawing.Color.Black;
            this.accountNumberLbl.Location = new System.Drawing.Point(26, 387);
            this.accountNumberLbl.Name = "accountNumberLbl";
            this.accountNumberLbl.Size = new System.Drawing.Size(160, 21);
            this.accountNumberLbl.TabIndex = 35;
            this.accountNumberLbl.Text = "Account Number";
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
            // departmentLbl
            // 
            this.departmentLbl.AutoSize = true;
            this.departmentLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departmentLbl.ForeColor = System.Drawing.Color.Black;
            this.departmentLbl.Location = new System.Drawing.Point(330, 317);
            this.departmentLbl.Name = "departmentLbl";
            this.departmentLbl.Size = new System.Drawing.Size(114, 21);
            this.departmentLbl.TabIndex = 32;
            this.departmentLbl.Text = "Department";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLbl.ForeColor = System.Drawing.Color.Black;
            this.firstNameLbl.Location = new System.Drawing.Point(26, 94);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(98, 20);
            this.firstNameLbl.TabIndex = 30;
            this.firstNameLbl.Text = "First Name";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLbl.ForeColor = System.Drawing.Color.Black;
            this.lastNameLbl.Location = new System.Drawing.Point(336, 94);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(96, 20);
            this.lastNameLbl.TabIndex = 29;
            this.lastNameLbl.Text = "Last Name";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLbl.ForeColor = System.Drawing.Color.Black;
            this.emailLbl.Location = new System.Drawing.Point(26, 169);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(59, 21);
            this.emailLbl.TabIndex = 25;
            this.emailLbl.Text = "Email";
            // 
            // phoneNumberLbl
            // 
            this.phoneNumberLbl.AutoSize = true;
            this.phoneNumberLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumberLbl.ForeColor = System.Drawing.Color.Black;
            this.phoneNumberLbl.Location = new System.Drawing.Point(26, 243);
            this.phoneNumberLbl.Name = "phoneNumberLbl";
            this.phoneNumberLbl.Size = new System.Drawing.Size(142, 21);
            this.phoneNumberLbl.TabIndex = 23;
            this.phoneNumberLbl.Text = "Phone Number";
            // 
            // salaryLbl
            // 
            this.salaryLbl.AutoSize = true;
            this.salaryLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salaryLbl.ForeColor = System.Drawing.Color.Black;
            this.salaryLbl.Location = new System.Drawing.Point(26, 317);
            this.salaryLbl.Name = "salaryLbl";
            this.salaryLbl.Size = new System.Drawing.Size(67, 21);
            this.salaryLbl.TabIndex = 22;
            this.salaryLbl.Text = "Salary";
            // 
            // editBtn
            // 
            this.editBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editBtn.ForeColor = System.Drawing.Color.Black;
            this.editBtn.Location = new System.Drawing.Point(189, 635);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(254, 42);
            this.editBtn.TabIndex = 17;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // dateOfEmployment
            // 
            this.dateOfEmployment.CalendarMonthBackground = System.Drawing.Color.SkyBlue;
            this.dateOfEmployment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateOfEmployment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfEmployment.Location = new System.Drawing.Point(272, 489);
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
            this.dateOfEmploymentLbl.Location = new System.Drawing.Point(272, 465);
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
            this.dateOfBirthLbl.Location = new System.Drawing.Point(78, 465);
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
            this.dateOfBirth.Location = new System.Drawing.Point(42, 489);
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
            this.gender.TextChanged += new System.EventHandler(this.gender_TextChanged);
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
            this.label1.Size = new System.Drawing.Size(220, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Employee";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1106, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1213, 737);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chooseImgBtn);
            this.Controls.Add(this.employeeImg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1231, 784);
            this.MinimumSize = new System.Drawing.Size(1231, 784);
            this.Name = "EditEmployee";
            this.Text = "EditEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.employeeImg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button chooseImgBtn;
        private System.Windows.Forms.PictureBox employeeImg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.ComboBox hoursPerDay;
        private System.Windows.Forms.Label hoursPerDayLbl;
        private System.Windows.Forms.Label accountNumberLbl;
        private System.Windows.Forms.TextBox accountNumber;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.Label departmentLbl;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label phoneNumberLbl;
        private System.Windows.Forms.Label salaryLbl;
        private System.Windows.Forms.Button editBtn;
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.Button button1;
    }
}