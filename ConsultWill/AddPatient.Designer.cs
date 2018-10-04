namespace ConsultWill
{
    partial class AddPatient
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPatientNo = new System.Windows.Forms.Label();
            this.lblReferringDoc = new System.Windows.Forms.Label();
            this.lblReferDocEmail = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLasteName = new System.Windows.Forms.TextBox();
            this.txtPatientNumber = new System.Windows.Forms.TextBox();
            this.txtReferringDoc = new System.Windows.Forms.TextBox();
            this.txtReferringDocEmail = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(2, 9);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(194, 9);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblPatientNo
            // 
            this.lblPatientNo.AutoSize = true;
            this.lblPatientNo.Location = new System.Drawing.Point(392, 9);
            this.lblPatientNo.Name = "lblPatientNo";
            this.lblPatientNo.Size = new System.Drawing.Size(78, 17);
            this.lblPatientNo.TabIndex = 2;
            this.lblPatientNo.Text = "Patient No.";
            // 
            // lblReferringDoc
            // 
            this.lblReferringDoc.AutoSize = true;
            this.lblReferringDoc.Location = new System.Drawing.Point(2, 65);
            this.lblReferringDoc.Name = "lblReferringDoc";
            this.lblReferringDoc.Size = new System.Drawing.Size(113, 17);
            this.lblReferringDoc.TabIndex = 3;
            this.lblReferringDoc.Text = "Referring Doctor";
            // 
            // lblReferDocEmail
            // 
            this.lblReferDocEmail.AutoSize = true;
            this.lblReferDocEmail.Location = new System.Drawing.Point(194, 56);
            this.lblReferDocEmail.Name = "lblReferDocEmail";
            this.lblReferDocEmail.Size = new System.Drawing.Size(207, 17);
            this.lblReferDocEmail.TabIndex = 4;
            this.lblReferDocEmail.Text = "Referring Doctor Email Address";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(3, 29);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(168, 22);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtLasteName
            // 
            this.txtLasteName.Location = new System.Drawing.Point(197, 29);
            this.txtLasteName.Name = "txtLasteName";
            this.txtLasteName.Size = new System.Drawing.Size(168, 22);
            this.txtLasteName.TabIndex = 6;
            // 
            // txtPatientNumber
            // 
            this.txtPatientNumber.Location = new System.Drawing.Point(395, 29);
            this.txtPatientNumber.Name = "txtPatientNumber";
            this.txtPatientNumber.Size = new System.Drawing.Size(168, 22);
            this.txtPatientNumber.TabIndex = 7;
            // 
            // txtReferringDoc
            // 
            this.txtReferringDoc.Location = new System.Drawing.Point(5, 85);
            this.txtReferringDoc.Name = "txtReferringDoc";
            this.txtReferringDoc.Size = new System.Drawing.Size(168, 22);
            this.txtReferringDoc.TabIndex = 8;
            // 
            // txtReferringDocEmail
            // 
            this.txtReferringDocEmail.Location = new System.Drawing.Point(197, 85);
            this.txtReferringDocEmail.Name = "txtReferringDocEmail";
            this.txtReferringDocEmail.Size = new System.Drawing.Size(168, 22);
            this.txtReferringDocEmail.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(488, 143);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(407, 143);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 31);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 186);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtReferringDocEmail);
            this.Controls.Add(this.txtReferringDoc);
            this.Controls.Add(this.txtPatientNumber);
            this.Controls.Add(this.txtLasteName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblReferDocEmail);
            this.Controls.Add(this.lblReferringDoc);
            this.Controls.Add(this.lblPatientNo);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPatient";
            this.Text = "AddPatient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPatientNo;
        private System.Windows.Forms.Label lblReferringDoc;
        private System.Windows.Forms.Label lblReferDocEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLasteName;
        private System.Windows.Forms.TextBox txtPatientNumber;
        private System.Windows.Forms.TextBox txtReferringDoc;
        private System.Windows.Forms.TextBox txtReferringDocEmail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}