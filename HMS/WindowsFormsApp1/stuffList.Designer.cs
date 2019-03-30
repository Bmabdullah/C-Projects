namespace WindowsFormsApp1
{
    partial class stuffList
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
            this.stuffListGridView = new System.Windows.Forms.DataGridView();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.designationTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bloodListButton = new System.Windows.Forms.Button();
            this.deleteBlood = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stuffListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stuffListGridView
            // 
            this.stuffListGridView.AllowUserToAddRows = false;
            this.stuffListGridView.AllowUserToDeleteRows = false;
            this.stuffListGridView.AllowUserToResizeColumns = false;
            this.stuffListGridView.AllowUserToResizeRows = false;
            this.stuffListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stuffListGridView.Location = new System.Drawing.Point(36, 3);
            this.stuffListGridView.Name = "stuffListGridView";
            this.stuffListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stuffListGridView.Size = new System.Drawing.Size(770, 248);
            this.stuffListGridView.TabIndex = 2;
            this.stuffListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.stuffListGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stuffListGridView_CellDoubleClick);
            // 
            // genderComboBox
            // 
            this.genderComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(476, 339);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(128, 21);
            this.genderComboBox.TabIndex = 60;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userNameTextBox.Location = new System.Drawing.Point(169, 411);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(126, 20);
            this.userNameTextBox.TabIndex = 64;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(301, 401);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(10);
            this.label11.Size = new System.Drawing.Size(113, 41);
            this.label11.TabIndex = 76;
            this.label11.Text = "Password :";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Location = new System.Drawing.Point(420, 411);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(127, 20);
            this.passwordTextBox.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(51, 401);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(10);
            this.label10.Size = new System.Drawing.Size(127, 41);
            this.label10.TabIndex = 75;
            this.label10.Text = "User Name : ";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(476, 366);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(201, 37);
            this.addressTextBox.TabIndex = 61;
            this.addressTextBox.Text = "";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(374, 362);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(10);
            this.label9.Size = new System.Drawing.Size(107, 41);
            this.label9.TabIndex = 74;
            this.label9.Text = "Address : ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(383, 329);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10);
            this.label8.Size = new System.Drawing.Size(99, 41);
            this.label8.TabIndex = 73;
            this.label8.Text = "Gender : ";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.salaryTextBox.Location = new System.Drawing.Point(169, 373);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(201, 20);
            this.salaryTextBox.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 363);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10);
            this.label7.Size = new System.Drawing.Size(89, 41);
            this.label7.TabIndex = 72;
            this.label7.Text = "Sallary :";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(169, 340);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 330);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10);
            this.label6.Size = new System.Drawing.Size(135, 41);
            this.label6.TabIndex = 71;
            this.label6.Text = "Joining Date : ";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneTextBox.Location = new System.Drawing.Point(476, 306);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(201, 20);
            this.phoneTextBox.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(390, 296);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10);
            this.label5.Size = new System.Drawing.Size(91, 41);
            this.label5.TabIndex = 70;
            this.label5.Text = "Phone : ";
            // 
            // designationTextBox
            // 
            this.designationTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.designationTextBox.Location = new System.Drawing.Point(169, 307);
            this.designationTextBox.Name = "designationTextBox";
            this.designationTextBox.Size = new System.Drawing.Size(201, 20);
            this.designationTextBox.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 297);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10);
            this.label4.Size = new System.Drawing.Size(126, 41);
            this.label4.TabIndex = 69;
            this.label4.Text = "Designation: ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.Location = new System.Drawing.Point(476, 274);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(201, 20);
            this.nameTextBox.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(399, 264);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10);
            this.label3.Size = new System.Drawing.Size(82, 41);
            this.label3.TabIndex = 68;
            this.label3.Text = "Name: ";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdTextBox.Location = new System.Drawing.Point(169, 274);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(201, 20);
            this.IdTextBox.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 264);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(63, 41);
            this.label2.TabIndex = 67;
            this.label2.Text = " ID: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(560, 406);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 29);
            this.button1.TabIndex = 79;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bloodListButton
            // 
            this.bloodListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bloodListButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodListButton.Location = new System.Drawing.Point(652, 425);
            this.bloodListButton.Margin = new System.Windows.Forms.Padding(0);
            this.bloodListButton.Name = "bloodListButton";
            this.bloodListButton.Size = new System.Drawing.Size(90, 29);
            this.bloodListButton.TabIndex = 78;
            this.bloodListButton.Text = "Refresh Now";
            this.bloodListButton.UseVisualStyleBackColor = false;
            this.bloodListButton.Click += new System.EventHandler(this.bloodListButton_Click);
            // 
            // deleteBlood
            // 
            this.deleteBlood.BackColor = System.Drawing.Color.Firebrick;
            this.deleteBlood.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBlood.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.deleteBlood.Location = new System.Drawing.Point(560, 445);
            this.deleteBlood.Margin = new System.Windows.Forms.Padding(0);
            this.deleteBlood.Name = "deleteBlood";
            this.deleteBlood.Size = new System.Drawing.Size(81, 29);
            this.deleteBlood.TabIndex = 77;
            this.deleteBlood.Text = "Delete";
            this.deleteBlood.UseVisualStyleBackColor = false;
            this.deleteBlood.Click += new System.EventHandler(this.deleteBlood_Click);
            // 
            // stuffList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bloodListButton);
            this.Controls.Add(this.deleteBlood);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.designationTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stuffListGridView);
            this.Name = "stuffList";
            this.Text = "stuffList";
            this.Load += new System.EventHandler(this.stuffList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stuffListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView stuffListGridView;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox addressTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox designationTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bloodListButton;
        private System.Windows.Forms.Button deleteBlood;
    }
}