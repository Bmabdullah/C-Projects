namespace WindowsFormsApp1
{
    partial class patientLogin
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
            this.getPassLogin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.getPhoneLogin = new System.Windows.Forms.TextBox();
            this.loginButtonPatient = new System.Windows.Forms.Button();
            this.forgetPassPatient = new System.Windows.Forms.Button();
            this.patientLoginGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.patientLoginGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient Login Window ";
            // 
            // getPassLogin
            // 
            this.getPassLogin.Location = new System.Drawing.Point(145, 160);
            this.getPassLogin.Name = "getPassLogin";
            this.getPassLogin.Size = new System.Drawing.Size(179, 20);
            this.getPassLogin.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 149);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10);
            this.label7.Size = new System.Drawing.Size(108, 41);
            this.label7.TabIndex = 5;
            this.label7.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 94);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(81, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phone:";
            // 
            // getPhoneLogin
            // 
            this.getPhoneLogin.Location = new System.Drawing.Point(145, 102);
            this.getPhoneLogin.Name = "getPhoneLogin";
            this.getPhoneLogin.Size = new System.Drawing.Size(179, 20);
            this.getPhoneLogin.TabIndex = 0;
            // 
            // loginButtonPatient
            // 
            this.loginButtonPatient.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButtonPatient.Location = new System.Drawing.Point(249, 217);
            this.loginButtonPatient.Name = "loginButtonPatient";
            this.loginButtonPatient.Size = new System.Drawing.Size(75, 32);
            this.loginButtonPatient.TabIndex = 2;
            this.loginButtonPatient.Text = "Login";
            this.loginButtonPatient.UseVisualStyleBackColor = true;
            this.loginButtonPatient.Click += new System.EventHandler(this.loginButtonPatient_Click);
            // 
            // forgetPassPatient
            // 
            this.forgetPassPatient.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetPassPatient.Location = new System.Drawing.Point(121, 217);
            this.forgetPassPatient.Name = "forgetPassPatient";
            this.forgetPassPatient.Size = new System.Drawing.Size(122, 32);
            this.forgetPassPatient.TabIndex = 9;
            this.forgetPassPatient.Text = "Forget Password";
            this.forgetPassPatient.UseVisualStyleBackColor = true;
            this.forgetPassPatient.Click += new System.EventHandler(this.forgetPassPatient_Click);
            // 
            // patientLoginGroupBox
            // 
            this.patientLoginGroupBox.Controls.Add(this.getPhoneLogin);
            this.patientLoginGroupBox.Controls.Add(this.loginButtonPatient);
            this.patientLoginGroupBox.Controls.Add(this.label1);
            this.patientLoginGroupBox.Controls.Add(this.forgetPassPatient);
            this.patientLoginGroupBox.Controls.Add(this.getPassLogin);
            this.patientLoginGroupBox.Controls.Add(this.label2);
            this.patientLoginGroupBox.Controls.Add(this.label7);
            this.patientLoginGroupBox.Location = new System.Drawing.Point(396, 77);
            this.patientLoginGroupBox.Name = "patientLoginGroupBox";
            this.patientLoginGroupBox.Size = new System.Drawing.Size(363, 290);
            this.patientLoginGroupBox.TabIndex = 10;
            this.patientLoginGroupBox.TabStop = false;
            this.patientLoginGroupBox.Text = "HMS Patient Login";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(42, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 214);
            this.panel1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(3, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hospital Management System";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(24, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Patient Login Form";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Peru;
            this.label3.Location = new System.Drawing.Point(23, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "LOGO";
            // 
            // patientLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.patientLoginGroupBox);
            this.Name = "patientLogin";
            this.Text = "patientLogin";
            this.patientLoginGroupBox.ResumeLayout(false);
            this.patientLoginGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox getPassLogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox getPhoneLogin;
        private System.Windows.Forms.Button loginButtonPatient;
        private System.Windows.Forms.Button forgetPassPatient;
        private System.Windows.Forms.GroupBox patientLoginGroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}