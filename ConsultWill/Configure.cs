using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultWill
{
    public partial class Configure : Form
    {
        public Configure()
        {
            InitializeComponent();
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                folderDlg.ShowNewFolderButton = true;
                // Show the FolderBrowserDialog.  
                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (Properties.Settings.Default.StorageFolder != null)
                        txtStorageFolder.Text = Properties.Settings.Default.StorageFolder;

                    Environment.SpecialFolder root = folderDlg.RootFolder;
                    Properties.Settings.Default.StorageFolder = folderDlg.SelectedPath;
                    Properties.Settings.Default.Save();

                }
            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
