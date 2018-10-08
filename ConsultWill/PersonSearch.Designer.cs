namespace ConsultWill
{
    partial class PersonSearch
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
            this.lstPatients = new System.Windows.Forms.ListBox();
            this.txtFindPatient = new System.Windows.Forms.TextBox();
            this.lblFindPatient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstPatients
            // 
            this.lstPatients.FormattingEnabled = true;
            this.lstPatients.Location = new System.Drawing.Point(2, 39);
            this.lstPatients.Margin = new System.Windows.Forms.Padding(2);
            this.lstPatients.Name = "lstPatients";
            this.lstPatients.Size = new System.Drawing.Size(196, 251);
            this.lstPatients.TabIndex = 8;
            this.lstPatients.SelectedIndexChanged += new System.EventHandler(this.lstPatients_SelectedIndexChanged);
            this.lstPatients.SelectedValueChanged += new System.EventHandler(this.lstPatients_SelectedValueChanged);
            this.lstPatients.DoubleClick += new System.EventHandler(this.lstPatients_DoubleClick);
            // 
            // txtFindPatient
            // 
            this.txtFindPatient.Location = new System.Drawing.Point(2, 15);
            this.txtFindPatient.Margin = new System.Windows.Forms.Padding(2);
            this.txtFindPatient.Name = "txtFindPatient";
            this.txtFindPatient.Size = new System.Drawing.Size(196, 20);
            this.txtFindPatient.TabIndex = 6;
            this.txtFindPatient.TextChanged += new System.EventHandler(this.txtFindPatient_TextChanged);
            // 
            // lblFindPatient
            // 
            this.lblFindPatient.AutoSize = true;
            this.lblFindPatient.Location = new System.Drawing.Point(-1, 0);
            this.lblFindPatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFindPatient.Name = "lblFindPatient";
            this.lblFindPatient.Size = new System.Drawing.Size(82, 13);
            this.lblFindPatient.TabIndex = 7;
            this.lblFindPatient.Text = "Search Patients";
            this.lblFindPatient.Click += new System.EventHandler(this.lblFindPatient_Click);
            // 
            // PersonSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lstPatients);
            this.Controls.Add(this.txtFindPatient);
            this.Controls.Add(this.lblFindPatient);
            this.Name = "PersonSearch";
            this.Size = new System.Drawing.Size(200, 300);
            this.Load += new System.EventHandler(this.PersonSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPatients;
        private System.Windows.Forms.TextBox txtFindPatient;
        private System.Windows.Forms.Label lblFindPatient;
    }
}
