namespace WindowsFormsApp1
{
    partial class stuffWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button19 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adminLogoutButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.button19);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.adminLogoutButton);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 99);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Active";
            // 
            // button19
            // 
            this.button19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button19.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button19.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button19.Location = new System.Drawing.Point(17, 49);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(93, 32);
            this.button19.TabIndex = 23;
            this.button19.Text = "E&xit";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "loged in as a Stuff";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // adminLogoutButton
            // 
            this.adminLogoutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adminLogoutButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.adminLogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.adminLogoutButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogoutButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adminLogoutButton.Location = new System.Drawing.Point(129, 49);
            this.adminLogoutButton.Name = "adminLogoutButton";
            this.adminLogoutButton.Size = new System.Drawing.Size(93, 32);
            this.adminLogoutButton.TabIndex = 1;
            this.adminLogoutButton.Text = "LogOut";
            this.adminLogoutButton.UseVisualStyleBackColor = false;
            this.adminLogoutButton.Click += new System.EventHandler(this.adminLogoutButton_Click);
            // 
            // stuffWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "stuffWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "stuffWindow";
            this.Load += new System.EventHandler(this.stuffWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminLogoutButton;
    }
}