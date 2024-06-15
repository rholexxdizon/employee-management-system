namespace EmployeeManagementSystem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addEmployee_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addEmployee_position = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addEmployeeClearBtn = new System.Windows.Forms.Button();
            this.addEmployeeDeleteBtn = new System.Windows.Forms.Button();
            this.addEmployeeUpdateBtn = new System.Windows.Forms.Button();
            this.addEmployeeAddBtn = new System.Windows.Forms.Button();
            this.addEmployeeImportBtn = new System.Windows.Forms.Button();
            this.addEmployee_picture = new System.Windows.Forms.PictureBox();
            this.addEmployee_phoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addEmployee_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addEmployee_fullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addEmployee_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 319);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(166)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(28, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(784, 231);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee\'s Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.addEmployee_status);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.addEmployee_position);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addEmployeeClearBtn);
            this.panel2.Controls.Add(this.addEmployeeDeleteBtn);
            this.panel2.Controls.Add(this.addEmployeeUpdateBtn);
            this.panel2.Controls.Add(this.addEmployeeAddBtn);
            this.panel2.Controls.Add(this.addEmployeeImportBtn);
            this.panel2.Controls.Add(this.addEmployee_picture);
            this.panel2.Controls.Add(this.addEmployee_phoneNumber);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.addEmployee_gender);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.addEmployee_fullName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.addEmployee_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(22, 357);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 182);
            this.panel2.TabIndex = 1;
            // 
            // addEmployee_status
            // 
            this.addEmployee_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addEmployee_status.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_status.FormattingEnabled = true;
            this.addEmployee_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.addEmployee_status.Location = new System.Drawing.Point(423, 93);
            this.addEmployee_status.Name = "addEmployee_status";
            this.addEmployee_status.Size = new System.Drawing.Size(151, 21);
            this.addEmployee_status.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(366, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 14);
            this.label7.TabIndex = 17;
            this.label7.Text = "Status:";
            // 
            // addEmployee_position
            // 
            this.addEmployee_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addEmployee_position.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_position.FormattingEnabled = true;
            this.addEmployee_position.Items.AddRange(new object[] {
            "UI/UX Designer",
            "Full-Stack Developer",
            "Front-End Developer",
            "Back-End Dveloper"});
            this.addEmployee_position.Location = new System.Drawing.Point(423, 57);
            this.addEmployee_position.Name = "addEmployee_position";
            this.addEmployee_position.Size = new System.Drawing.Size(151, 21);
            this.addEmployee_position.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(366, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 14);
            this.label6.TabIndex = 15;
            this.label6.Text = "Position:";
            // 
            // addEmployeeClearBtn
            // 
            this.addEmployeeClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.addEmployeeClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployeeClearBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeClearBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addEmployeeClearBtn.Location = new System.Drawing.Point(584, 132);
            this.addEmployeeClearBtn.Name = "addEmployeeClearBtn";
            this.addEmployeeClearBtn.Size = new System.Drawing.Size(97, 39);
            this.addEmployeeClearBtn.TabIndex = 14;
            this.addEmployeeClearBtn.Text = "Clear";
            this.addEmployeeClearBtn.UseVisualStyleBackColor = false;
            this.addEmployeeClearBtn.Click += new System.EventHandler(this.addEmployeeClearBtn_Click);
            // 
            // addEmployeeDeleteBtn
            // 
            this.addEmployeeDeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.addEmployeeDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployeeDeleteBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeDeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addEmployeeDeleteBtn.Location = new System.Drawing.Point(456, 132);
            this.addEmployeeDeleteBtn.Name = "addEmployeeDeleteBtn";
            this.addEmployeeDeleteBtn.Size = new System.Drawing.Size(97, 39);
            this.addEmployeeDeleteBtn.TabIndex = 13;
            this.addEmployeeDeleteBtn.Text = "Delete";
            this.addEmployeeDeleteBtn.UseVisualStyleBackColor = false;
            this.addEmployeeDeleteBtn.Click += new System.EventHandler(this.addEmployeeDeleteBtn_Click);
            // 
            // addEmployeeUpdateBtn
            // 
            this.addEmployeeUpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.addEmployeeUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployeeUpdateBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeUpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addEmployeeUpdateBtn.Location = new System.Drawing.Point(331, 132);
            this.addEmployeeUpdateBtn.Name = "addEmployeeUpdateBtn";
            this.addEmployeeUpdateBtn.Size = new System.Drawing.Size(97, 39);
            this.addEmployeeUpdateBtn.TabIndex = 12;
            this.addEmployeeUpdateBtn.Text = "Update";
            this.addEmployeeUpdateBtn.UseVisualStyleBackColor = false;
            this.addEmployeeUpdateBtn.Click += new System.EventHandler(this.addEmployeeUpdateBtn_Click);
            // 
            // addEmployeeAddBtn
            // 
            this.addEmployeeAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.addEmployeeAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployeeAddBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeAddBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addEmployeeAddBtn.Location = new System.Drawing.Point(205, 132);
            this.addEmployeeAddBtn.Name = "addEmployeeAddBtn";
            this.addEmployeeAddBtn.Size = new System.Drawing.Size(97, 39);
            this.addEmployeeAddBtn.TabIndex = 11;
            this.addEmployeeAddBtn.Text = "Add";
            this.addEmployeeAddBtn.UseVisualStyleBackColor = false;
            this.addEmployeeAddBtn.Click += new System.EventHandler(this.addEmployeeAddBtn_Click);
            // 
            // addEmployeeImportBtn
            // 
            this.addEmployeeImportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.addEmployeeImportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployeeImportBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeImportBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addEmployeeImportBtn.Location = new System.Drawing.Point(726, 108);
            this.addEmployeeImportBtn.Name = "addEmployeeImportBtn";
            this.addEmployeeImportBtn.Size = new System.Drawing.Size(82, 23);
            this.addEmployeeImportBtn.TabIndex = 9;
            this.addEmployeeImportBtn.Text = "Import";
            this.addEmployeeImportBtn.UseVisualStyleBackColor = false;
            this.addEmployeeImportBtn.Click += new System.EventHandler(this.addEmployeeImportBtn_Click);
            // 
            // addEmployee_picture
            // 
            this.addEmployee_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addEmployee_picture.Image = global::EmployeeManagementSystem.Properties.Resources.picture_82px;
            this.addEmployee_picture.Location = new System.Drawing.Point(726, 17);
            this.addEmployee_picture.Name = "addEmployee_picture";
            this.addEmployee_picture.Size = new System.Drawing.Size(82, 90);
            this.addEmployee_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addEmployee_picture.TabIndex = 8;
            this.addEmployee_picture.TabStop = false;
            // 
            // addEmployee_phoneNumber
            // 
            this.addEmployee_phoneNumber.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_phoneNumber.Location = new System.Drawing.Point(423, 19);
            this.addEmployee_phoneNumber.Name = "addEmployee_phoneNumber";
            this.addEmployee_phoneNumber.Size = new System.Drawing.Size(151, 21);
            this.addEmployee_phoneNumber.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(328, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone Number:";
            // 
            // addEmployee_gender
            // 
            this.addEmployee_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addEmployee_gender.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_gender.FormattingEnabled = true;
            this.addEmployee_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.addEmployee_gender.Location = new System.Drawing.Point(125, 93);
            this.addEmployee_gender.Name = "addEmployee_gender";
            this.addEmployee_gender.Size = new System.Drawing.Size(151, 21);
            this.addEmployee_gender.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(68, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender:";
            // 
            // addEmployee_fullName
            // 
            this.addEmployee_fullName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_fullName.Location = new System.Drawing.Point(125, 55);
            this.addEmployee_fullName.Name = "addEmployee_fullName";
            this.addEmployee_fullName.Size = new System.Drawing.Size(151, 21);
            this.addEmployee_fullName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(56, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name:";
            // 
            // addEmployee_id
            // 
            this.addEmployee_id.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_id.Location = new System.Drawing.Point(125, 17);
            this.addEmployee_id.Name = "addEmployee_id";
            this.addEmployee_id.Size = new System.Drawing.Size(151, 21);
            this.addEmployee_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(39, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee ID:";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(875, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox addEmployee_gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addEmployee_fullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addEmployee_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addEmployee_phoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox addEmployee_picture;
        private System.Windows.Forms.Button addEmployeeImportBtn;
        private System.Windows.Forms.Button addEmployeeClearBtn;
        private System.Windows.Forms.Button addEmployeeDeleteBtn;
        private System.Windows.Forms.Button addEmployeeUpdateBtn;
        private System.Windows.Forms.Button addEmployeeAddBtn;
        private System.Windows.Forms.ComboBox addEmployee_position;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox addEmployee_status;
        private System.Windows.Forms.Label label7;
    }
}
