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
            this.lblReferringDocFname = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLasteName = new System.Windows.Forms.TextBox();
            this.txtPatientNumber = new System.Windows.Forms.TextBox();
            this.txtReferringDocFname = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtReferEmail = new System.Windows.Forms.TextBox();
            this.lblReferringDocEmail = new System.Windows.Forms.Label();
            this.txtReferringDocLname = new System.Windows.Forms.TextBox();
            this.lblReferrringDocLName = new System.Windows.Forms.Label();
            this.grpPatient = new System.Windows.Forms.GroupBox();
            this.grpReferringDoctor = new System.Windows.Forms.GroupBox();
            this.grpPatient.SuspendLayout();
            this.grpReferringDoctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(7, 18);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(151, 18);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblPatientNo
            // 
            this.lblPatientNo.AutoSize = true;
            this.lblPatientNo.Location = new System.Drawing.Point(299, 18);
            this.lblPatientNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatientNo.Name = "lblPatientNo";
            this.lblPatientNo.Size = new System.Drawing.Size(60, 13);
            this.lblPatientNo.TabIndex = 2;
            this.lblPatientNo.Text = "Patient No.";
            // 
            // lblReferringDocFname
            // 
            this.lblReferringDocFname.AutoSize = true;
            this.lblReferringDocFname.Location = new System.Drawing.Point(9, 19);
            this.lblReferringDocFname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReferringDocFname.Name = "lblReferringDocFname";
            this.lblReferringDocFname.Size = new System.Drawing.Size(57, 13);
            this.lblReferringDocFname.TabIndex = 3;
            this.lblReferringDocFname.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(7, 35);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(131, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLasteName
            // 
            this.txtLasteName.Location = new System.Drawing.Point(153, 35);
            this.txtLasteName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLasteName.Name = "txtLasteName";
            this.txtLasteName.Size = new System.Drawing.Size(130, 20);
            this.txtLasteName.TabIndex = 1;
            // 
            // txtPatientNumber
            // 
            this.txtPatientNumber.Location = new System.Drawing.Point(302, 33);
            this.txtPatientNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtPatientNumber.Name = "txtPatientNumber";
            this.txtPatientNumber.Size = new System.Drawing.Size(127, 20);
            this.txtPatientNumber.TabIndex = 2;
            // 
            // txtReferringDocFname
            // 
            this.txtReferringDocFname.Location = new System.Drawing.Point(11, 35);
            this.txtReferringDocFname.Margin = new System.Windows.Forms.Padding(2);
            this.txtReferringDocFname.Name = "txtReferringDocFname";
            this.txtReferringDocFname.Size = new System.Drawing.Size(127, 20);
            this.txtReferringDocFname.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(383, 149);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 25);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(322, 149);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(56, 25);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtReferEmail
            // 
            this.txtReferEmail.Location = new System.Drawing.Point(302, 35);
            this.txtReferEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtReferEmail.Name = "txtReferEmail";
            this.txtReferEmail.Size = new System.Drawing.Size(127, 20);
            this.txtReferEmail.TabIndex = 5;
            // 
            // lblReferringDocEmail
            // 
            this.lblReferringDocEmail.AutoSize = true;
            this.lblReferringDocEmail.Location = new System.Drawing.Point(299, 20);
            this.lblReferringDocEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReferringDocEmail.Name = "lblReferringDocEmail";
            this.lblReferringDocEmail.Size = new System.Drawing.Size(113, 13);
            this.lblReferringDocEmail.TabIndex = 12;
            this.lblReferringDocEmail.Text = "Referring Doctor Email";
            // 
            // txtReferringDocLname
            // 
            this.txtReferringDocLname.Location = new System.Drawing.Point(156, 35);
            this.txtReferringDocLname.Margin = new System.Windows.Forms.Padding(2);
            this.txtReferringDocLname.Name = "txtReferringDocLname";
            this.txtReferringDocLname.Size = new System.Drawing.Size(127, 20);
            this.txtReferringDocLname.TabIndex = 4;
            // 
            // lblReferrringDocLName
            // 
            this.lblReferrringDocLName.AutoSize = true;
            this.lblReferrringDocLName.Location = new System.Drawing.Point(154, 19);
            this.lblReferrringDocLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReferrringDocLName.Name = "lblReferrringDocLName";
            this.lblReferrringDocLName.Size = new System.Drawing.Size(85, 13);
            this.lblReferrringDocLName.TabIndex = 14;
            this.lblReferrringDocLName.Text = "Referring Doctor";
            // 
            // grpPatient
            // 
            this.grpPatient.Controls.Add(this.txtFirstName);
            this.grpPatient.Controls.Add(this.lblFirstName);
            this.grpPatient.Controls.Add(this.lblLastName);
            this.grpPatient.Controls.Add(this.lblPatientNo);
            this.grpPatient.Controls.Add(this.txtLasteName);
            this.grpPatient.Controls.Add(this.txtPatientNumber);
            this.grpPatient.Location = new System.Drawing.Point(10, 3);
            this.grpPatient.Name = "grpPatient";
            this.grpPatient.Size = new System.Drawing.Size(437, 66);
            this.grpPatient.TabIndex = 16;
            this.grpPatient.TabStop = false;
            this.grpPatient.Text = "Patient";
            // 
            // grpReferringDoctor
            // 
            this.grpReferringDoctor.Controls.Add(this.txtReferringDocLname);
            this.grpReferringDoctor.Controls.Add(this.lblReferringDocFname);
            this.grpReferringDoctor.Controls.Add(this.txtReferringDocFname);
            this.grpReferringDoctor.Controls.Add(this.lblReferrringDocLName);
            this.grpReferringDoctor.Controls.Add(this.lblReferringDocEmail);
            this.grpReferringDoctor.Controls.Add(this.txtReferEmail);
            this.grpReferringDoctor.Location = new System.Drawing.Point(10, 75);
            this.grpReferringDoctor.Name = "grpReferringDoctor";
            this.grpReferringDoctor.Size = new System.Drawing.Size(437, 69);
            this.grpReferringDoctor.TabIndex = 8;
            this.grpReferringDoctor.TabStop = false;
            this.grpReferringDoctor.Text = "Referrring Doctor";
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 178);
            this.ControlBox = false;
            this.Controls.Add(this.grpReferringDoctor);
            this.Controls.Add(this.grpPatient);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Patient";
            this.Load += new System.EventHandler(this.AddPatient_Load);
            this.grpPatient.ResumeLayout(false);
            this.grpPatient.PerformLayout();
            this.grpReferringDoctor.ResumeLayout(false);
            this.grpReferringDoctor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPatientNo;
        private System.Windows.Forms.Label lblReferringDocFname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLasteName;
        private System.Windows.Forms.TextBox txtPatientNumber;
        private System.Windows.Forms.TextBox txtReferringDocFname;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtReferEmail;
        private System.Windows.Forms.Label lblReferringDocEmail;
        private System.Windows.Forms.TextBox txtReferringDocLname;
        private System.Windows.Forms.Label lblReferrringDocLName;
        private System.Windows.Forms.GroupBox grpPatient;
        private System.Windows.Forms.GroupBox grpReferringDoctor;
    }
}