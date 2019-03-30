namespace WindowsFormsApp1
{
    partial class doctorList
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
            this.button1 = new System.Windows.Forms.Button();
            this.doctorListGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.doctorListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Doctor List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // doctorListGridView
            // 
            this.doctorListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorListGridView.Location = new System.Drawing.Point(50, 73);
            this.doctorListGridView.Name = "doctorListGridView";
            this.doctorListGridView.Size = new System.Drawing.Size(687, 304);
            this.doctorListGridView.TabIndex = 2;
            this.doctorListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctorListGridView_CellContentClick);
            // 
            // doctorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doctorListGridView);
            this.Controls.Add(this.button1);
            this.Name = "doctorList";
            this.Text = "doctorList";
            this.Load += new System.EventHandler(this.doctorList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorListGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView doctorListGridView;
    }
}