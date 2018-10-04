namespace ConsultWill
{
    partial class frmConsult
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
            this.btnConfigure = new System.Windows.Forms.Button();
            this.btnCreatePatient = new System.Windows.Forms.Button();
            this.btnTodaysConsults = new System.Windows.Forms.Button();
            this.txtFindPatient = new System.Windows.Forms.TextBox();
            this.lblFindPatient = new System.Windows.Forms.Label();
            this.lstPatients = new System.Windows.Forms.ListBox();
            this.btnNewConsult = new System.Windows.Forms.Button();
            this.btnCompleteConsult = new System.Windows.Forms.Button();
            this.btnInstructionsForPa = new System.Windows.Forms.Button();
            this.btnOrderCoffee = new System.Windows.Forms.Button();
            this.btnAttachFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPatientFiles = new System.Windows.Forms.ListBox();
            this.btnFirePatient = new System.Windows.Forms.Button();
            this.btnViewPatientFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConfigure
            // 
            this.btnConfigure.Location = new System.Drawing.Point(636, 9);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(104, 23);
            this.btnConfigure.TabIndex = 0;
            this.btnConfigure.Text = "Configuration";
            this.btnConfigure.UseVisualStyleBackColor = true;
            this.btnConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // btnCreatePatient
            // 
            this.btnCreatePatient.Location = new System.Drawing.Point(372, 41);
            this.btnCreatePatient.Name = "btnCreatePatient";
            this.btnCreatePatient.Size = new System.Drawing.Size(172, 108);
            this.btnCreatePatient.TabIndex = 1;
            this.btnCreatePatient.Text = "New Patient";
            this.btnCreatePatient.UseVisualStyleBackColor = true;
            this.btnCreatePatient.Click += new System.EventHandler(this.btnCreatePatient_Click);
            // 
            // btnTodaysConsults
            // 
            this.btnTodaysConsults.Enabled = false;
            this.btnTodaysConsults.Location = new System.Drawing.Point(372, 301);
            this.btnTodaysConsults.Name = "btnTodaysConsults";
            this.btnTodaysConsults.Size = new System.Drawing.Size(172, 108);
            this.btnTodaysConsults.TabIndex = 2;
            this.btnTodaysConsults.Text = "Todays Consults";
            this.btnTodaysConsults.UseVisualStyleBackColor = true;
            // 
            // txtFindPatient
            // 
            this.txtFindPatient.Location = new System.Drawing.Point(36, 41);
            this.txtFindPatient.Name = "txtFindPatient";
            this.txtFindPatient.Size = new System.Drawing.Size(301, 22);
            this.txtFindPatient.TabIndex = 3;
            this.txtFindPatient.TextChanged += new System.EventHandler(this.txtFindPatient_TextChanged);
            // 
            // lblFindPatient
            // 
            this.lblFindPatient.AutoSize = true;
            this.lblFindPatient.Location = new System.Drawing.Point(33, 15);
            this.lblFindPatient.Name = "lblFindPatient";
            this.lblFindPatient.Size = new System.Drawing.Size(108, 17);
            this.lblFindPatient.TabIndex = 4;
            this.lblFindPatient.Text = "Search Patients";
            // 
            // lstPatients
            // 
            this.lstPatients.FormattingEnabled = true;
            this.lstPatients.ItemHeight = 16;
            this.lstPatients.Location = new System.Drawing.Point(36, 69);
            this.lstPatients.Name = "lstPatients";
            this.lstPatients.Size = new System.Drawing.Size(301, 468);
            this.lstPatients.TabIndex = 5;
            this.lstPatients.SelectedIndexChanged += new System.EventHandler(this.lstPatients_SelectedIndexChanged);
            this.lstPatients.SelectedValueChanged += new System.EventHandler(this.lstPatients_SelectedValueChanged);
            // 
            // btnNewConsult
            // 
            this.btnNewConsult.Enabled = false;
            this.btnNewConsult.Location = new System.Drawing.Point(372, 174);
            this.btnNewConsult.Name = "btnNewConsult";
            this.btnNewConsult.Size = new System.Drawing.Size(172, 108);
            this.btnNewConsult.TabIndex = 6;
            this.btnNewConsult.Text = "New Consult";
            this.btnNewConsult.UseVisualStyleBackColor = true;
            // 
            // btnCompleteConsult
            // 
            this.btnCompleteConsult.Enabled = false;
            this.btnCompleteConsult.Location = new System.Drawing.Point(568, 41);
            this.btnCompleteConsult.Name = "btnCompleteConsult";
            this.btnCompleteConsult.Size = new System.Drawing.Size(172, 108);
            this.btnCompleteConsult.TabIndex = 7;
            this.btnCompleteConsult.Text = "Add Clinical Notes";
            this.btnCompleteConsult.UseVisualStyleBackColor = true;
            this.btnCompleteConsult.Click += new System.EventHandler(this.btnCompleteConsult_Click);
            // 
            // btnInstructionsForPa
            // 
            this.btnInstructionsForPa.Enabled = false;
            this.btnInstructionsForPa.Location = new System.Drawing.Point(568, 174);
            this.btnInstructionsForPa.Name = "btnInstructionsForPa";
            this.btnInstructionsForPa.Size = new System.Drawing.Size(172, 108);
            this.btnInstructionsForPa.TabIndex = 8;
            this.btnInstructionsForPa.Text = "Add ClipboardInstructions";
            this.btnInstructionsForPa.UseVisualStyleBackColor = true;
            this.btnInstructionsForPa.Click += new System.EventHandler(this.btnInstructionsForPa_Click);
            // 
            // btnOrderCoffee
            // 
            this.btnOrderCoffee.Location = new System.Drawing.Point(568, 428);
            this.btnOrderCoffee.Name = "btnOrderCoffee";
            this.btnOrderCoffee.Size = new System.Drawing.Size(172, 108);
            this.btnOrderCoffee.TabIndex = 9;
            this.btnOrderCoffee.Text = "Order Coffee";
            this.btnOrderCoffee.UseVisualStyleBackColor = true;
            this.btnOrderCoffee.Click += new System.EventHandler(this.btnOrderCoffee_Click);
            // 
            // btnAttachFile
            // 
            this.btnAttachFile.Enabled = false;
            this.btnAttachFile.Location = new System.Drawing.Point(372, 428);
            this.btnAttachFile.Name = "btnAttachFile";
            this.btnAttachFile.Size = new System.Drawing.Size(172, 108);
            this.btnAttachFile.TabIndex = 10;
            this.btnAttachFile.Text = "Attach X-Ray or file";
            this.btnAttachFile.UseVisualStyleBackColor = true;
            this.btnAttachFile.Click += new System.EventHandler(this.btnAttachFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 555);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Patient X-Rays and Photos";
            // 
            // lstPatientFiles
            // 
            this.lstPatientFiles.FormattingEnabled = true;
            this.lstPatientFiles.ItemHeight = 16;
            this.lstPatientFiles.Location = new System.Drawing.Point(36, 575);
            this.lstPatientFiles.Name = "lstPatientFiles";
            this.lstPatientFiles.Size = new System.Drawing.Size(704, 84);
            this.lstPatientFiles.TabIndex = 14;
            this.lstPatientFiles.SelectedIndexChanged += new System.EventHandler(this.lstPatientFiles_SelectedIndexChanged);
            this.lstPatientFiles.DoubleClick += new System.EventHandler(this.lstPatientFiles_DoubleClick);
            // 
            // btnFirePatient
            // 
            this.btnFirePatient.Enabled = false;
            this.btnFirePatient.Location = new System.Drawing.Point(672, 522);
            this.btnFirePatient.Name = "btnFirePatient";
            this.btnFirePatient.Size = new System.Drawing.Size(172, 108);
            this.btnFirePatient.TabIndex = 15;
            this.btnFirePatient.Text = "Fire Patient";
            this.btnFirePatient.UseVisualStyleBackColor = true;
            this.btnFirePatient.Visible = false;
            // 
            // btnViewPatientFile
            // 
            this.btnViewPatientFile.Location = new System.Drawing.Point(568, 301);
            this.btnViewPatientFile.Name = "btnViewPatientFile";
            this.btnViewPatientFile.Size = new System.Drawing.Size(172, 108);
            this.btnViewPatientFile.TabIndex = 16;
            this.btnViewPatientFile.Text = "View Patient File";
            this.btnViewPatientFile.UseVisualStyleBackColor = true;
            this.btnViewPatientFile.Click += new System.EventHandler(this.btnViewPatientFile_Click);
            // 
            // frmConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 698);
            this.Controls.Add(this.btnViewPatientFile);
            this.Controls.Add(this.btnFirePatient);
            this.Controls.Add(this.lstPatientFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAttachFile);
            this.Controls.Add(this.btnOrderCoffee);
            this.Controls.Add(this.btnInstructionsForPa);
            this.Controls.Add(this.btnCompleteConsult);
            this.Controls.Add(this.btnNewConsult);
            this.Controls.Add(this.lstPatients);
            this.Controls.Add(this.lblFindPatient);
            this.Controls.Add(this.txtFindPatient);
            this.Controls.Add(this.btnTodaysConsults);
            this.Controls.Add(this.btnCreatePatient);
            this.Controls.Add(this.btnConfigure);
            this.Name = "frmConsult";
            this.Text = "Mr William Haynes Consulting";
            this.Load += new System.EventHandler(this.frmConsult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfigure;
        private System.Windows.Forms.Button btnCreatePatient;
        private System.Windows.Forms.Button btnTodaysConsults;
        private System.Windows.Forms.TextBox txtFindPatient;
        private System.Windows.Forms.Label lblFindPatient;
        private System.Windows.Forms.ListBox lstPatients;
        private System.Windows.Forms.Button btnNewConsult;
        private System.Windows.Forms.Button btnCompleteConsult;
        private System.Windows.Forms.Button btnInstructionsForPa;
        private System.Windows.Forms.Button btnOrderCoffee;
        private System.Windows.Forms.Button btnAttachFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPatientFiles;
        private System.Windows.Forms.Button btnFirePatient;
        private System.Windows.Forms.Button btnViewPatientFile;
    }
}

