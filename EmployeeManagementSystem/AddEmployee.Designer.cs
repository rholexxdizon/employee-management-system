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
            this.addEmployeeStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addEmployeePosition = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addEmployeeClearBtn = new System.Windows.Forms.Button();
            this.addEmployeeDeleteBtn = new System.Windows.Forms.Button();
            this.addEmployeeUpdateBtn = new System.Windows.Forms.Button();
            this.addEmployeeAddBtn = new System.Windows.Forms.Button();
            this.addEmployeeImportBtn = new System.Windows.Forms.Button();
            this.addEmployeePicture = new System.Windows.Forms.PictureBox();
            this.addEmployeePhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addEmployeeGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addEmployeeFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addEmployeeId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployeePicture)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(29, 61);
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
            this.panel2.Controls.Add(this.addEmployeeStatus);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.addEmployeePosition);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addEmployeeClearBtn);
            this.panel2.Controls.Add(this.addEmployeeDeleteBtn);
            this.panel2.Controls.Add(this.addEmployeeUpdateBtn);
            this.panel2.Controls.Add(this.addEmployeeAddBtn);
            this.panel2.Controls.Add(this.addEmployeeImportBtn);
            this.panel2.Controls.Add(this.addEmployeePicture);
            this.panel2.Controls.Add(this.addEmployeePhoneNumber);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.addEmployeeGender);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.addEmployeeFullName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.addEmployeeId);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(22, 357);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 182);
            this.panel2.TabIndex = 1;
            // 
            // addEmployeeStatus
            // 
            this.addEmployeeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addEmployeeStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeStatus.FormattingEnabled = true;
            this.addEmployeeStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.addEmployeeStatus.Location = new System.Drawing.Point(423, 93);
            this.addEmployeeStatus.Name = "addEmployeeStatus";
            this.addEmployeeStatus.Size = new System.Drawing.Size(151, 21);
            this.addEmployeeStatus.TabIndex = 18;
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
            // addEmployeePosition
            // 
            this.addEmployeePosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addEmployeePosition.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeePosition.FormattingEnabled = true;
            this.addEmployeePosition.Items.AddRange(new object[] {
            "UI/UX Designer",
            "Full-Stack Developer",
            "Front-End Developer",
            "Back-End Dveloper"});
            this.addEmployeePosition.Location = new System.Drawing.Point(423, 57);
            this.addEmployeePosition.Name = "addEmployeePosition";
            this.addEmployeePosition.Size = new System.Drawing.Size(151, 21);
            this.addEmployeePosition.TabIndex = 16;
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
            // addEmployeePicture
            // 
            this.addEmployeePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addEmployeePicture.Image = global::EmployeeManagementSystem.Properties.Resources.picture_82px;
            this.addEmployeePicture.Location = new System.Drawing.Point(726, 17);
            this.addEmployeePicture.Name = "addEmployeePicture";
            this.addEmployeePicture.Size = new System.Drawing.Size(82, 90);
            this.addEmployeePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addEmployeePicture.TabIndex = 8;
            this.addEmployeePicture.TabStop = false;
            // 
            // addEmployeePhoneNumber
            // 
            this.addEmployeePhoneNumber.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeePhoneNumber.Location = new System.Drawing.Point(423, 19);
            this.addEmployeePhoneNumber.Name = "addEmployeePhoneNumber";
            this.addEmployeePhoneNumber.Size = new System.Drawing.Size(151, 21);
            this.addEmployeePhoneNumber.TabIndex = 7;
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
            // addEmployeeGender
            // 
            this.addEmployeeGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addEmployeeGender.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeGender.FormattingEnabled = true;
            this.addEmployeeGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.addEmployeeGender.Location = new System.Drawing.Point(125, 93);
            this.addEmployeeGender.Name = "addEmployeeGender";
            this.addEmployeeGender.Size = new System.Drawing.Size(151, 21);
            this.addEmployeeGender.TabIndex = 5;
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
            // addEmployeeFullName
            // 
            this.addEmployeeFullName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeFullName.Location = new System.Drawing.Point(125, 55);
            this.addEmployeeFullName.Name = "addEmployeeFullName";
            this.addEmployeeFullName.Size = new System.Drawing.Size(151, 21);
            this.addEmployeeFullName.TabIndex = 3;
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
            // addEmployeeId
            // 
            this.addEmployeeId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeId.Location = new System.Drawing.Point(125, 17);
            this.addEmployeeId.Name = "addEmployeeId";
            this.addEmployeeId.Size = new System.Drawing.Size(151, 21);
            this.addEmployeeId.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.addEmployeePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox addEmployeeGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addEmployeeFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addEmployeeId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addEmployeePhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox addEmployeePicture;
        private System.Windows.Forms.Button addEmployeeImportBtn;
        private System.Windows.Forms.Button addEmployeeClearBtn;
        private System.Windows.Forms.Button addEmployeeDeleteBtn;
        private System.Windows.Forms.Button addEmployeeUpdateBtn;
        private System.Windows.Forms.Button addEmployeeAddBtn;
        private System.Windows.Forms.ComboBox addEmployeePosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox addEmployeeStatus;
        private System.Windows.Forms.Label label7;
    }
}
