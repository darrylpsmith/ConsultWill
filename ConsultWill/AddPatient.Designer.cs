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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLasteName = new System.Windows.Forms.TextBox();
            this.txtPatientNumber = new System.Windows.Forms.TextBox();
            this.txtReferringDoc = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtReferEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(2, 7);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(146, 7);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblPatientNo
            // 
            this.lblPatientNo.AutoSize = true;
            this.lblPatientNo.Location = new System.Drawing.Point(294, 7);
            this.lblPatientNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatientNo.Name = "lblPatientNo";
            this.lblPatientNo.Size = new System.Drawing.Size(60, 13);
            this.lblPatientNo.TabIndex = 2;
            this.lblPatientNo.Text = "Patient No.";
            // 
            // lblReferringDoc
            // 
            this.lblReferringDoc.AutoSize = true;
            this.lblReferringDoc.Location = new System.Drawing.Point(2, 53);
            this.lblReferringDoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReferringDoc.Name = "lblReferringDoc";
            this.lblReferringDoc.Size = new System.Drawing.Size(85, 13);
            this.lblReferringDoc.TabIndex = 3;
            this.lblReferringDoc.Text = "Referring Doctor";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(2, 24);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(127, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtLasteName
            // 
            this.txtLasteName.Location = new System.Drawing.Point(148, 24);
            this.txtLasteName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLasteName.Name = "txtLasteName";
            this.txtLasteName.Size = new System.Drawing.Size(127, 20);
            this.txtLasteName.TabIndex = 6;
            // 
            // txtPatientNumber
            // 
            this.txtPatientNumber.Location = new System.Drawing.Point(296, 24);
            this.txtPatientNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPatientNumber.Name = "txtPatientNumber";
            this.txtPatientNumber.Size = new System.Drawing.Size(127, 20);
            this.txtPatientNumber.TabIndex = 7;
            // 
            // txtReferringDoc
            // 
            this.txtReferringDoc.Location = new System.Drawing.Point(4, 69);
            this.txtReferringDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtReferringDoc.Name = "txtReferringDoc";
            this.txtReferringDoc.Size = new System.Drawing.Size(127, 20);
            this.txtReferringDoc.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(366, 116);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 25);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(305, 116);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(56, 25);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtReferEmail
            // 
            this.txtReferEmail.Location = new System.Drawing.Point(148, 69);
            this.txtReferEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtReferEmail.Name = "txtReferEmail";
            this.txtReferEmail.Size = new System.Drawing.Size(127, 20);
            this.txtReferEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(146, 53);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(113, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Referring Doctor Email";
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 151);
            this.ControlBox = false;
            this.Controls.Add(this.txtReferEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtReferringDoc);
            this.Controls.Add(this.txtPatientNumber);
            this.Controls.Add(this.txtLasteName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblReferringDoc);
            this.Controls.Add(this.lblPatientNo);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPatientNo;
        private System.Windows.Forms.Label lblReferringDoc;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLasteName;
        private System.Windows.Forms.TextBox txtPatientNumber;
        private System.Windows.Forms.TextBox txtReferringDoc;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtReferEmail;
        private System.Windows.Forms.Label lblEmail;
    }
}