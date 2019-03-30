namespace WindowsFormsApp1
{
    partial class prescription
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
            this.exitButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.doctorDept = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.patientPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pAge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pWaight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.bp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bs = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.advice = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.rx = new System.Windows.Forms.RichTextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.meet = new System.Windows.Forms.TextBox();
            this.symptom = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitButton.Location = new System.Drawing.Point(611, 464);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 29);
            this.exitButton.TabIndex = 33;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.logoutButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logoutButton.Location = new System.Drawing.Point(706, 464);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(0);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(88, 29);
            this.logoutButton.TabIndex = 32;
            this.logoutButton.Text = "Go Back";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 41);
            this.label1.TabIndex = 36;
            this.label1.Text = "Prescription";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.Location = new System.Drawing.Point(135, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(163, 20);
            this.nameTextBox.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10);
            this.label3.Size = new System.Drawing.Size(140, 41);
            this.label3.TabIndex = 41;
            this.label3.Text = "Doctor Name: ";
            // 
            // doctorDept
            // 
            this.doctorDept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doctorDept.Location = new System.Drawing.Point(408, 59);
            this.doctorDept.Name = "doctorDept";
            this.doctorDept.Size = new System.Drawing.Size(119, 20);
            this.doctorDept.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 48);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(125, 41);
            this.label2.TabIndex = 43;
            this.label2.Text = "Depertment: ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(527, 48);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10);
            this.label4.Size = new System.Drawing.Size(73, 41);
            this.label4.TabIndex = 45;
            this.label4.Text = "Date: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(588, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 46;
            // 
            // patientPhone
            // 
            this.patientPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientPhone.Location = new System.Drawing.Point(372, 93);
            this.patientPhone.Name = "patientPhone";
            this.patientPhone.Size = new System.Drawing.Size(128, 20);
            this.patientPhone.TabIndex = 47;
            this.patientPhone.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(302, 82);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10);
            this.label5.Size = new System.Drawing.Size(81, 41);
            this.label5.TabIndex = 48;
            this.label5.Text = "Phone:";
            // 
            // pName
            // 
            this.pName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pName.Location = new System.Drawing.Point(134, 93);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(163, 20);
            this.pName.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 82);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10);
            this.label6.Size = new System.Drawing.Size(137, 41);
            this.label6.TabIndex = 50;
            this.label6.Text = "Patient Name: ";
            // 
            // pAge
            // 
            this.pAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pAge.Location = new System.Drawing.Point(556, 93);
            this.pAge.Name = "pAge";
            this.pAge.Size = new System.Drawing.Size(59, 20);
            this.pAge.TabIndex = 51;
            this.pAge.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(503, 82);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10);
            this.label7.Size = new System.Drawing.Size(64, 41);
            this.label7.TabIndex = 52;
            this.label7.Text = "Age:";
            // 
            // pWaight
            // 
            this.pWaight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pWaight.Location = new System.Drawing.Point(699, 93);
            this.pWaight.Name = "pWaight";
            this.pWaight.Size = new System.Drawing.Size(59, 20);
            this.pWaight.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(621, 82);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10);
            this.label8.Size = new System.Drawing.Size(85, 41);
            this.label8.TabIndex = 54;
            this.label8.Text = "Waight:";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.ForestGreen;
            this.label21.Location = new System.Drawing.Point(12, 116);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(177, 29);
            this.label21.TabIndex = 55;
            this.label21.Text = "     Test Results      ";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bp
            // 
            this.bp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bp.Location = new System.Drawing.Point(63, 155);
            this.bp.Name = "bp";
            this.bp.Size = new System.Drawing.Size(84, 20);
            this.bp.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 145);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(10);
            this.label9.Size = new System.Drawing.Size(53, 41);
            this.label9.TabIndex = 57;
            this.label9.Text = "BP";
            // 
            // bs
            // 
            this.bs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bs.Location = new System.Drawing.Point(93, 186);
            this.bs.Name = "bs";
            this.bs.Size = new System.Drawing.Size(84, 20);
            this.bs.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 176);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(10);
            this.label10.Size = new System.Drawing.Size(90, 41);
            this.label10.TabIndex = 59;
            this.label10.Text = "B.Sugar";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.ForestGreen;
            this.label11.Location = new System.Drawing.Point(15, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 29);
            this.label11.TabIndex = 60;
            this.label11.Text = "      Symptoms       ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.ForestGreen;
            this.label14.Location = new System.Drawing.Point(15, 345);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(177, 29);
            this.label14.TabIndex = 67;
            this.label14.Text = "      Advice       ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // advice
            // 
            this.advice.Location = new System.Drawing.Point(16, 377);
            this.advice.Name = "advice";
            this.advice.Size = new System.Drawing.Size(173, 85);
            this.advice.TabIndex = 69;
            this.advice.Text = "";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.ForestGreen;
            this.label17.Location = new System.Drawing.Point(304, 126);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(296, 29);
            this.label17.TabIndex = 70;
            this.label17.Text = "      Medicine And Routine       ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(249, 173);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(177, 29);
            this.label18.TabIndex = 71;
            this.label18.Text = "RX.";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rx
            // 
            this.rx.Location = new System.Drawing.Point(308, 210);
            this.rx.Name = "rx";
            this.rx.Size = new System.Drawing.Size(439, 210);
            this.rx.TabIndex = 73;
            this.rx.Text = "";
            this.rx.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Lime;
            this.updateButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateButton.Location = new System.Drawing.Point(659, 423);
            this.updateButton.Margin = new System.Windows.Forms.Padding(0);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(88, 39);
            this.updateButton.TabIndex = 74;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label19.Location = new System.Drawing.Point(221, 463);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(222, 29);
            this.label19.TabIndex = 75;
            this.label19.Text = "Meet Again After  ";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label20.Location = new System.Drawing.Point(432, 463);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(101, 29);
            this.label20.TabIndex = 77;
            this.label20.Text = "days";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // meet
            // 
            this.meet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.meet.Location = new System.Drawing.Point(406, 468);
            this.meet.Name = "meet";
            this.meet.Size = new System.Drawing.Size(50, 20);
            this.meet.TabIndex = 78;
            // 
            // symptom
            // 
            this.symptom.Location = new System.Drawing.Point(19, 246);
            this.symptom.Name = "symptom";
            this.symptom.Size = new System.Drawing.Size(173, 96);
            this.symptom.TabIndex = 79;
            this.symptom.Text = "";
            this.symptom.TextChanged += new System.EventHandler(this.symptom_TextChanged);
            // 
            // prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.symptom);
            this.Controls.Add(this.meet);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.rx);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.advice);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bs);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.pWaight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pAge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.patientPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.doctorDept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.logoutButton);
            this.Name = "prescription";
            this.Text = "prescription";
            this.Load += new System.EventHandler(this.prescription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox doctorDept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox patientPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pWaight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox bp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox bs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox advice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RichTextBox rx;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox meet;
        private System.Windows.Forms.RichTextBox symptom;
    }
}