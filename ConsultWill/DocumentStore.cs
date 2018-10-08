using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ConsultWill
{
    public partial class DocumentStore : UserControl
    {
        DocumentAssignmentFolder _docFolder = null;
        private string _currPerson = null;

        public DocumentStore(DocumentAssignmentFolder DocFolder, int Left, int Top)
        {
            InitializeComponent();

            _docFolder = DocFolder;
            this.Left = Left;
            this.Top = Top;

            this.lblDescription.Text = DocFolder.DisplayName;

        }

        public string CurrentPerson
        {
            set
            {
                _currPerson = value;
                PopulatePatientAttachedFiles();
            }

            get
            {
                return _currPerson;
            }
        }

        private void DocumentStore_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string radFolder = StaticFunctions.GetSelectedPatientDocumentFolder(_currPerson, _docFolder.FolderName);
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (!Directory.Exists(radFolder))
                        Directory.CreateDirectory(radFolder);


                    string selectedFile = openFileDialog1.FileName;
                    string fileName = Path.GetFileName(selectedFile);

                    File.Copy(selectedFile, radFolder + fileName);

                    if (_docFolder.RemoveSourceFilesWhenAssigningToFolder)
                        File.Delete(selectedFile);

                    PopulatePatientAttachedFiles();
                }
            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }
        }



        private void lstDocuments_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (lstDocuments.SelectedItem != null)
                {
                    if (lstDocuments.SelectedItem.ToString().Length != 0)
                    {
                        string radFolder = StaticFunctions.GetSelectedPatientDocumentFolder(_currPerson, _docFolder.FolderName);
                        string file = radFolder + lstDocuments.SelectedItem.ToString();
                        System.Diagnostics.Process.Start(file);
                    }
                }
            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }
        }

        public void PopulatePatientAttachedFiles()
        {
            lstDocuments.Items.Clear();
            string radFolder = StaticFunctions.GetSelectedPatientDocumentFolder(_currPerson, _docFolder.FolderName);
            if (Directory.Exists(radFolder))
            {
                DirectoryInfo DirInfo = new DirectoryInfo(radFolder);

                var filesInOrder = from f in DirInfo.EnumerateFiles()
                                    orderby f.CreationTime descending
                                    select f;

                foreach (var file in filesInOrder)
                {
                    string fileName = Path.GetFileName(file.FullName);
                    lstDocuments.Items.Add(fileName);
                }
            }
        }
    }
}
