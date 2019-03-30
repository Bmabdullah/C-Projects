namespace WindowsFormsApp1
{
    partial class patientList
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
            this.patientListGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.updateBlood = new System.Windows.Forms.Button();
            this.bloodListButton = new System.Windows.Forms.Button();
            this.deleteBlood = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // patientListGridView
            // 
            this.patientListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientListGridView.Location = new System.Drawing.Point(60, 12);
            this.patientListGridView.Name = "patientListGridView";
            this.patientListGridView.Size = new System.Drawing.Size(692, 250);
            this.patientListGridView.TabIndex = 1;
            this.patientListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "Enter The Tergeted Phone Number: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(262, 281);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 43;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(109, 318);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(109, 20);
            this.nameBox.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "Name :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(109, 354);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(48, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 18);
            this.label9.TabIndex = 60;
            this.label9.Text = "Gender :";
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(109, 381);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(109, 20);
            this.ageBox.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 62;
            this.label5.Text = "Age :";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(305, 354);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(109, 47);
            this.addressTextBox.TabIndex = 65;
            this.addressTextBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(240, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 64;
            this.label6.Text = "Address :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 66;
            this.label1.Text = "Password :";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(305, 315);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(109, 20);
            this.passBox.TabIndex = 67;
            // 
            // updateBlood
            // 
            this.updateBlood.BackColor = System.Drawing.Color.Firebrick;
            this.updateBlood.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBlood.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.updateBlood.Location = new System.Drawing.Point(454, 329);
            this.updateBlood.Margin = new System.Windows.Forms.Padding(0);
            this.updateBlood.Name = "updateBlood";
            this.updateBlood.Size = new System.Drawing.Size(81, 29);
            this.updateBlood.TabIndex = 70;
            this.updateBlood.Text = "Update";
            this.updateBlood.UseVisualStyleBackColor = false;
            this.updateBlood.Click += new System.EventHandler(this.button1_Click);
            // 
            // bloodListButton
            // 
            this.bloodListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bloodListButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodListButton.Location = new System.Drawing.Point(561, 342);
            this.bloodListButton.Margin = new System.Windows.Forms.Padding(0);
            this.bloodListButton.Name = "bloodListButton";
            this.bloodListButton.Size = new System.Drawing.Size(90, 29);
            this.bloodListButton.TabIndex = 69;
            this.bloodListButton.Text = "Refresh Now";
            this.bloodListButton.UseVisualStyleBackColor = false;
            this.bloodListButton.Click += new System.EventHandler(this.bloodListButton_Click);
            // 
            // deleteBlood
            // 
            this.deleteBlood.BackColor = System.Drawing.Color.Firebrick;
            this.deleteBlood.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBlood.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.deleteBlood.Location = new System.Drawing.Point(454, 376);
            this.deleteBlood.Margin = new System.Windows.Forms.Padding(0);
            this.deleteBlood.Name = "deleteBlood";
            this.deleteBlood.Size = new System.Drawing.Size(81, 29);
            this.deleteBlood.TabIndex = 68;
            this.deleteBlood.Text = "Delete";
            this.deleteBlood.UseVisualStyleBackColor = false;
            this.deleteBlood.Click += new System.EventHandler(this.deleteBlood_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(454, 281);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 25);
            this.button2.TabIndex = 71;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // patientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.updateBlood);
            this.Controls.Add(this.bloodListButton);
            this.Controls.Add(this.deleteBlood);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.patientListGridView);
            this.Name = "patientList";
            this.Text = "patientList";
            this.Load += new System.EventHandler(this.patientList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView patientListGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox addressTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button updateBlood;
        private System.Windows.Forms.Button bloodListButton;
        private System.Windows.Forms.Button deleteBlood;
        private System.Windows.Forms.Button button2;
    }
}