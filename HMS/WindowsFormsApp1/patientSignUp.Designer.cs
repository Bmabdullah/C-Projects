namespace WindowsFormsApp1
{
    partial class patientSignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.patientRegistereButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.patientAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.patientAddress = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.patientPass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rePatientPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Patient SignUp";
            // 
            // patientRegistereButton
            // 
            this.patientRegistereButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientRegistereButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.patientRegistereButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.patientRegistereButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientRegistereButton.Location = new System.Drawing.Point(559, 413);
            this.patientRegistereButton.Name = "patientRegistereButton";
            this.patientRegistereButton.Size = new System.Drawing.Size(107, 50);
            this.patientRegistereButton.TabIndex = 9;
            this.patientRegistereButton.Text = "Register";
            this.patientRegistereButton.UseVisualStyleBackColor = false;
            this.patientRegistereButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 79);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.label2.Size = new System.Drawing.Size(82, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.Location = new System.Drawing.Point(164, 91);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(201, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(435, 164);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.label5.Size = new System.Drawing.Size(64, 41);
            this.label5.TabIndex = 2;
            this.label5.Text = "Age:";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // patientAge
            // 
            this.patientAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientAge.Location = new System.Drawing.Point(599, 172);
            this.patientAge.Name = "patientAge";
            this.patientAge.Size = new System.Drawing.Size(93, 20);
            this.patientAge.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 230);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.label6.Size = new System.Drawing.Size(97, 41);
            this.label6.TabIndex = 2;
            this.label6.Text = "Address:";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneTextBox.Location = new System.Drawing.Point(599, 100);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(179, 20);
            this.phoneTextBox.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(435, 91);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.label7.Size = new System.Drawing.Size(81, 41);
            this.label7.TabIndex = 2;
            this.label7.Text = "Phone:";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Perpetua", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(218, 428);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(281, 24);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already Registered ? LogIn Now.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // patientAddress
            // 
            this.patientAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientAddress.Location = new System.Drawing.Point(164, 232);
            this.patientAddress.Name = "patientAddress";
            this.patientAddress.Size = new System.Drawing.Size(201, 66);
            this.patientAddress.TabIndex = 5;
            this.patientAddress.Text = "";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(435, 221);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.label8.Size = new System.Drawing.Size(139, 41);
            this.label8.TabIndex = 2;
            this.label8.Text = "New Pasword:";
            this.label8.Click += new System.EventHandler(this.label2_Click);
            // 
            // patientPass
            // 
            this.patientPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientPass.Location = new System.Drawing.Point(599, 232);
            this.patientPass.Name = "patientPass";
            this.patientPass.Size = new System.Drawing.Size(179, 20);
            this.patientPass.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(435, 276);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.label9.Size = new System.Drawing.Size(158, 41);
            this.label9.TabIndex = 2;
            this.label9.Text = "Retype Pasword:";
            this.label9.Click += new System.EventHandler(this.label2_Click);
            // 
            // rePatientPass
            // 
            this.rePatientPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rePatientPass.Location = new System.Drawing.Point(599, 287);
            this.rePatientPass.Name = "rePatientPass";
            this.rePatientPass.Size = new System.Drawing.Size(179, 20);
            this.rePatientPass.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 151);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.label3.Size = new System.Drawing.Size(94, 41);
            this.label3.TabIndex = 12;
            this.label3.Text = "Gender: ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(525, 89);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.label4.Size = new System.Drawing.Size(68, 41);
            this.label4.TabIndex = 13;
            this.label4.Text = "+880";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(164, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // patientSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 506);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.patientAddress);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rePatientPass);
            this.Controls.Add(this.patientPass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.patientAge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patientRegistereButton);
            this.Controls.Add(this.label1);
            this.Name = "patientSignUp";
            this.Text = "patientSignUp";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button patientRegistereButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox patientAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RichTextBox patientAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox patientPass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox rePatientPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}