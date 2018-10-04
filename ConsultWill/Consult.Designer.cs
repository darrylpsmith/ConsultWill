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
            this.btnCreatePatient = new System.Windows.Forms.Button();
            this.btnAddTodaysConsults = new System.Windows.Forms.Button();
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
            this.btnViewPatientFile = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTodaysPatients = new System.Windows.Forms.Label();
            this.lvwTodaysPatients = new System.Windows.Forms.ListView();
            this.colPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClearTodaysConsults = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreatePatient
            // 
            this.btnCreatePatient.Location = new System.Drawing.Point(272, 61);
            this.btnCreatePatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreatePatient.Name = "btnCreatePatient";
            this.btnCreatePatient.Size = new System.Drawing.Size(129, 88);
            this.btnCreatePatient.TabIndex = 1;
            this.btnCreatePatient.Text = "New Patient";
            this.btnCreatePatient.UseVisualStyleBackColor = true;
            this.btnCreatePatient.Click += new System.EventHandler(this.btnCreatePatient_Click);
            // 
            // btnAddTodaysConsults
            // 
            this.btnAddTodaysConsults.Enabled = false;
            this.btnAddTodaysConsults.Location = new System.Drawing.Point(272, 273);
            this.btnAddTodaysConsults.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTodaysConsults.Name = "btnAddTodaysConsults";
            this.btnAddTodaysConsults.Size = new System.Drawing.Size(129, 88);
            this.btnAddTodaysConsults.TabIndex = 2;
            this.btnAddTodaysConsults.Text = "Add to Todays Consults";
            this.btnAddTodaysConsults.UseVisualStyleBackColor = true;
            this.btnAddTodaysConsults.Click += new System.EventHandler(this.btnAddTodaysConsults_Click);
            // 
            // txtFindPatient
            // 
            this.txtFindPatient.Location = new System.Drawing.Point(20, 61);
            this.txtFindPatient.Margin = new System.Windows.Forms.Padding(2);
            this.txtFindPatient.Name = "txtFindPatient";
            this.txtFindPatient.Size = new System.Drawing.Size(227, 20);
            this.txtFindPatient.TabIndex = 3;
            this.txtFindPatient.TextChanged += new System.EventHandler(this.txtFindPatient_TextChanged);
            // 
            // lblFindPatient
            // 
            this.lblFindPatient.AutoSize = true;
            this.lblFindPatient.Location = new System.Drawing.Point(18, 40);
            this.lblFindPatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFindPatient.Name = "lblFindPatient";
            this.lblFindPatient.Size = new System.Drawing.Size(82, 13);
            this.lblFindPatient.TabIndex = 4;
            this.lblFindPatient.Text = "Search Patients";
            // 
            // lstPatients
            // 
            this.lstPatients.FormattingEnabled = true;
            this.lstPatients.Location = new System.Drawing.Point(20, 84);
            this.lstPatients.Margin = new System.Windows.Forms.Padding(2);
            this.lstPatients.Name = "lstPatients";
            this.lstPatients.Size = new System.Drawing.Size(227, 381);
            this.lstPatients.TabIndex = 5;
            this.lstPatients.SelectedIndexChanged += new System.EventHandler(this.lstPatients_SelectedIndexChanged);
            this.lstPatients.SelectedValueChanged += new System.EventHandler(this.lstPatients_SelectedValueChanged);
            this.lstPatients.DoubleClick += new System.EventHandler(this.lstPatients_DoubleClick);
            // 
            // btnNewConsult
            // 
            this.btnNewConsult.Enabled = false;
            this.btnNewConsult.Location = new System.Drawing.Point(272, 169);
            this.btnNewConsult.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewConsult.Name = "btnNewConsult";
            this.btnNewConsult.Size = new System.Drawing.Size(129, 88);
            this.btnNewConsult.TabIndex = 6;
            this.btnNewConsult.Text = "New Consult";
            this.btnNewConsult.UseVisualStyleBackColor = true;
            // 
            // btnCompleteConsult
            // 
            this.btnCompleteConsult.Enabled = false;
            this.btnCompleteConsult.Location = new System.Drawing.Point(419, 61);
            this.btnCompleteConsult.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompleteConsult.Name = "btnCompleteConsult";
            this.btnCompleteConsult.Size = new System.Drawing.Size(129, 88);
            this.btnCompleteConsult.TabIndex = 7;
            this.btnCompleteConsult.Text = "Add Clinical Notes";
            this.btnCompleteConsult.UseVisualStyleBackColor = true;
            this.btnCompleteConsult.Click += new System.EventHandler(this.btnCompleteConsult_Click);
            // 
            // btnInstructionsForPa
            // 
            this.btnInstructionsForPa.Enabled = false;
            this.btnInstructionsForPa.Location = new System.Drawing.Point(419, 169);
            this.btnInstructionsForPa.Margin = new System.Windows.Forms.Padding(2);
            this.btnInstructionsForPa.Name = "btnInstructionsForPa";
            this.btnInstructionsForPa.Size = new System.Drawing.Size(129, 88);
            this.btnInstructionsForPa.TabIndex = 8;
            this.btnInstructionsForPa.Text = "Add Clipboard Instructions";
            this.btnInstructionsForPa.UseVisualStyleBackColor = true;
            this.btnInstructionsForPa.Click += new System.EventHandler(this.btnInstructionsForPa_Click);
            // 
            // btnOrderCoffee
            // 
            this.btnOrderCoffee.Location = new System.Drawing.Point(419, 376);
            this.btnOrderCoffee.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderCoffee.Name = "btnOrderCoffee";
            this.btnOrderCoffee.Size = new System.Drawing.Size(129, 88);
            this.btnOrderCoffee.TabIndex = 9;
            this.btnOrderCoffee.Text = "Order Coffee";
            this.btnOrderCoffee.UseVisualStyleBackColor = true;
            this.btnOrderCoffee.Click += new System.EventHandler(this.btnOrderCoffee_Click);
            // 
            // btnAttachFile
            // 
            this.btnAttachFile.Enabled = false;
            this.btnAttachFile.Location = new System.Drawing.Point(272, 376);
            this.btnAttachFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttachFile.Name = "btnAttachFile";
            this.btnAttachFile.Size = new System.Drawing.Size(129, 88);
            this.btnAttachFile.TabIndex = 10;
            this.btnAttachFile.Text = "Attach X-Ray or file";
            this.btnAttachFile.UseVisualStyleBackColor = true;
            this.btnAttachFile.Click += new System.EventHandler(this.btnAttachFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 479);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Patient Files";
            // 
            // lstPatientFiles
            // 
            this.lstPatientFiles.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lstPatientFiles.FormattingEnabled = true;
            this.lstPatientFiles.Location = new System.Drawing.Point(20, 495);
            this.lstPatientFiles.Margin = new System.Windows.Forms.Padding(2);
            this.lstPatientFiles.Name = "lstPatientFiles";
            this.lstPatientFiles.Size = new System.Drawing.Size(776, 69);
            this.lstPatientFiles.TabIndex = 14;
            this.lstPatientFiles.SelectedIndexChanged += new System.EventHandler(this.lstPatientFiles_SelectedIndexChanged);
            this.lstPatientFiles.DoubleClick += new System.EventHandler(this.lstPatientFiles_DoubleClick);
            // 
            // btnViewPatientFile
            // 
            this.btnViewPatientFile.Location = new System.Drawing.Point(419, 273);
            this.btnViewPatientFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewPatientFile.Name = "btnViewPatientFile";
            this.btnViewPatientFile.Size = new System.Drawing.Size(129, 88);
            this.btnViewPatientFile.TabIndex = 16;
            this.btnViewPatientFile.Text = "View Patient File";
            this.btnViewPatientFile.UseVisualStyleBackColor = true;
            this.btnViewPatientFile.Click += new System.EventHandler(this.btnViewPatientFile_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // lblTodaysPatients
            // 
            this.lblTodaysPatients.AutoSize = true;
            this.lblTodaysPatients.Location = new System.Drawing.Point(566, 40);
            this.lblTodaysPatients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTodaysPatients.Name = "lblTodaysPatients";
            this.lblTodaysPatients.Size = new System.Drawing.Size(83, 13);
            this.lblTodaysPatients.TabIndex = 19;
            this.lblTodaysPatients.Text = "Todays Patients";
            // 
            // lvwTodaysPatients
            // 
            this.lvwTodaysPatients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPatient});
            this.lvwTodaysPatients.ForeColor = System.Drawing.Color.BlueViolet;
            this.lvwTodaysPatients.Location = new System.Drawing.Point(569, 61);
            this.lvwTodaysPatients.Name = "lvwTodaysPatients";
            this.lvwTodaysPatients.Size = new System.Drawing.Size(215, 374);
            this.lvwTodaysPatients.TabIndex = 20;
            this.lvwTodaysPatients.UseCompatibleStateImageBehavior = false;
            this.lvwTodaysPatients.SelectedIndexChanged += new System.EventHandler(this.lvwTodaysPatients_SelectedIndexChanged);
            // 
            // colPatient
            // 
            this.colPatient.Width = 180;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(709, 441);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClearTodaysConsults
            // 
            this.btnClearTodaysConsults.Location = new System.Drawing.Point(628, 442);
            this.btnClearTodaysConsults.Name = "btnClearTodaysConsults";
            this.btnClearTodaysConsults.Size = new System.Drawing.Size(75, 23);
            this.btnClearTodaysConsults.TabIndex = 22;
            this.btnClearTodaysConsults.Text = "Clear All";
            this.btnClearTodaysConsults.UseVisualStyleBackColor = true;
            this.btnClearTodaysConsults.Click += new System.EventHandler(this.btnClearTodaysConsults_Click);
            // 
            // frmConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 571);
            this.Controls.Add(this.btnClearTodaysConsults);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lvwTodaysPatients);
            this.Controls.Add(this.lblTodaysPatients);
            this.Controls.Add(this.btnViewPatientFile);
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
            this.Controls.Add(this.btnAddTodaysConsults);
            this.Controls.Add(this.btnCreatePatient);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConsult";
            this.Text = "Mr William Haynes Consulting - Version 2";
            this.Load += new System.EventHandler(this.frmConsult_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreatePatient;
        private System.Windows.Forms.Button btnAddTodaysConsults;
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
        private System.Windows.Forms.Button btnViewPatientFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.Label lblTodaysPatients;
        private System.Windows.Forms.ListView lvwTodaysPatients;
        private System.Windows.Forms.ColumnHeader colPatient;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClearTodaysConsults;
    }
}

