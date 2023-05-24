
namespace Managment_System_Ptoject
{
    partial class ViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EmployesTable = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolBar = new System.Windows.Forms.GroupBox();
            this.editEmployeeBtn = new System.Windows.Forms.Button();
            this.removeEmployeeBtn = new System.Windows.Forms.Button();
            this.AddEmployeeBtn = new System.Windows.Forms.Button();
            this.searchLbl = new System.Windows.Forms.Label();
            this.searchTbx = new System.Windows.Forms.TextBox();
            this.searchChoice = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployesTable)).BeginInit();
            this.toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployesTable
            // 
            this.EmployesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployesTable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployesTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.EmployesTable.Location = new System.Drawing.Point(12, 139);
            this.EmployesTable.Name = "EmployesTable";
            this.EmployesTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployesTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.EmployesTable.RowHeadersWidth = 51;
            this.EmployesTable.RowTemplate.Height = 29;
            this.EmployesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployesTable.Size = new System.Drawing.Size(1458, 524);
            this.EmployesTable.TabIndex = 0;
            this.EmployesTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EmployesTable_CellMouseDoubleClick);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = global::Managment_System_Ptoject.Properties.Resources.backArrow;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(6, 28);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(58, 40);
            this.backBtn.TabIndex = 1;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(478, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee\'s Table";
            // 
            // toolBar
            // 
            this.toolBar.Controls.Add(this.editEmployeeBtn);
            this.toolBar.Controls.Add(this.removeEmployeeBtn);
            this.toolBar.Controls.Add(this.AddEmployeeBtn);
            this.toolBar.Controls.Add(this.backBtn);
            this.toolBar.Location = new System.Drawing.Point(12, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(1458, 74);
            this.toolBar.TabIndex = 3;
            this.toolBar.TabStop = false;
            this.toolBar.Text = "ToolBar";
            // 
            // editEmployeeBtn
            // 
            this.editEmployeeBtn.BackColor = System.Drawing.Color.Transparent;
            this.editEmployeeBtn.BackgroundImage = global::Managment_System_Ptoject.Properties.Resources.editIcon;
            this.editEmployeeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editEmployeeBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editEmployeeBtn.ForeColor = System.Drawing.Color.Black;
            this.editEmployeeBtn.Location = new System.Drawing.Point(256, 12);
            this.editEmployeeBtn.Name = "editEmployeeBtn";
            this.editEmployeeBtn.Size = new System.Drawing.Size(69, 56);
            this.editEmployeeBtn.TabIndex = 4;
            this.editEmployeeBtn.UseVisualStyleBackColor = false;
            this.editEmployeeBtn.Click += new System.EventHandler(this.editEmployeeBtn_Click);
            // 
            // removeEmployeeBtn
            // 
            this.removeEmployeeBtn.BackColor = System.Drawing.Color.Transparent;
            this.removeEmployeeBtn.BackgroundImage = global::Managment_System_Ptoject.Properties.Resources.removeEmployee;
            this.removeEmployeeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeEmployeeBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeEmployeeBtn.ForeColor = System.Drawing.Color.Black;
            this.removeEmployeeBtn.Location = new System.Drawing.Point(171, 12);
            this.removeEmployeeBtn.Name = "removeEmployeeBtn";
            this.removeEmployeeBtn.Size = new System.Drawing.Size(69, 56);
            this.removeEmployeeBtn.TabIndex = 3;
            this.removeEmployeeBtn.UseVisualStyleBackColor = false;
            this.removeEmployeeBtn.Click += new System.EventHandler(this.removeEmployeeBtn_Click);
            // 
            // AddEmployeeBtn
            // 
            this.AddEmployeeBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddEmployeeBtn.BackgroundImage = global::Managment_System_Ptoject.Properties.Resources.addEmp;
            this.AddEmployeeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployeeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddEmployeeBtn.ForeColor = System.Drawing.Color.Black;
            this.AddEmployeeBtn.Location = new System.Drawing.Point(85, 12);
            this.AddEmployeeBtn.Name = "AddEmployeeBtn";
            this.AddEmployeeBtn.Size = new System.Drawing.Size(69, 56);
            this.AddEmployeeBtn.TabIndex = 2;
            this.AddEmployeeBtn.UseVisualStyleBackColor = false;
            this.AddEmployeeBtn.Click += new System.EventHandler(this.AddEmployeeBtn_Click);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchLbl.Location = new System.Drawing.Point(32, 673);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(97, 20);
            this.searchLbl.TabIndex = 4;
            this.searchLbl.Text = "Search By:";
            // 
            // searchTbx
            // 
            this.searchTbx.Location = new System.Drawing.Point(203, 697);
            this.searchTbx.Name = "searchTbx";
            this.searchTbx.Size = new System.Drawing.Size(394, 27);
            this.searchTbx.TabIndex = 5;
            this.searchTbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTbx_KeyDown);
            // 
            // searchChoice
            // 
            this.searchChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchChoice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchChoice.FormattingEnabled = true;
            this.searchChoice.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Serial Number",
            "Phone Number"});
            this.searchChoice.Location = new System.Drawing.Point(32, 699);
            this.searchChoice.Name = "searchChoice";
            this.searchChoice.Size = new System.Drawing.Size(151, 25);
            this.searchChoice.TabIndex = 6;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.searchChoice);
            this.Controls.Add(this.searchTbx);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployesTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1500, 800);
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "ViewForm";
            this.Text = "Employee\'s Table";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.EmployesTable)).EndInit();
            this.toolBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox toolBar;
        private System.Windows.Forms.Button removeEmployeeBtn;
        private System.Windows.Forms.Button AddEmployeeBtn;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.TextBox searchTbx;
        private System.Windows.Forms.ComboBox searchChoice;
        public System.Windows.Forms.DataGridView EmployesTable;
        private System.Windows.Forms.Button editEmployeeBtn;
    }
}