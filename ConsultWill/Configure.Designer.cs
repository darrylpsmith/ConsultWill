namespace ConsultWill
{
    partial class Configure
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.txtStorageFolder = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStorageFolder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(548, 26);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(31, 22);
            this.btnChooseFolder.TabIndex = 0;
            this.btnChooseFolder.Text = "...";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // txtStorageFolder
            // 
            this.txtStorageFolder.Location = new System.Drawing.Point(12, 26);
            this.txtStorageFolder.Name = "txtStorageFolder";
            this.txtStorageFolder.Size = new System.Drawing.Size(530, 22);
            this.txtStorageFolder.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(423, 67);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(504, 67);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblStorageFolder
            // 
            this.lblStorageFolder.AutoSize = true;
            this.lblStorageFolder.Location = new System.Drawing.Point(9, 6);
            this.lblStorageFolder.Name = "lblStorageFolder";
            this.lblStorageFolder.Size = new System.Drawing.Size(164, 17);
            this.lblStorageFolder.TabIndex = 4;
            this.lblStorageFolder.Text = "DropBox Folder Location";
            // 
            // Configure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 109);
            this.Controls.Add(this.lblStorageFolder);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtStorageFolder);
            this.Controls.Add(this.btnChooseFolder);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configure";
            this.Text = "Configure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.TextBox txtStorageFolder;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblStorageFolder;
    }
}