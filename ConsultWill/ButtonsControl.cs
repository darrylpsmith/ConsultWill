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
    public partial class ButtonsControl : UserControl
    {

        public delegate void PersonCreated(string Person);
        public event PersonCreated personCreated;

        public delegate void AddPersonToTodayConsults(string Person);
        public event AddPersonToTodayConsults addPersonToTodayConsults;

        public delegate void AddPersonButtonPressed();
        public event AddPersonButtonPressed addPersonButtonPressed;

        public delegate void AddPersonButtonCancelled();
        public event AddPersonButtonCancelled addPersonButtonCancelled;

        public delegate void AddOperationButtonPressed();
        public event AddOperationButtonPressed addOperationButtonPressed;



        public delegate void StatusMessagee(string Status, bool DisableUI);
        public event StatusMessagee statusMessagee;


        string _currPerson = null;
        public ButtonsControl()
        {
            InitializeComponent();
        }

        public string CurrentPerson
        {
            set
            {
                _currPerson = value;

                btnCompleteConsult.Enabled = (_currPerson != null);
                btnInstructionsForPa.Enabled = (_currPerson != null);
                btnAddTodaysConsults.Enabled = (_currPerson != null);
                btnViewPatientFile.Enabled = (_currPerson != null);
                btnPostOp.Enabled = (_currPerson != null);
            }
                
            get
            {
                return _currPerson;
            }
        }

        private void btnCreatePatient_Click(object sender, EventArgs e)
        {

            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;

            // Execute your time-intensive hashing code here...

            // Set cursor as default arrow
            Cursor.Current = Cursors.Default;
            try
            {

                addPersonButtonPressed();

                AddPatient add = new AddPatient();
                add.ShowDialog();
                string patientName = add.PatientName;
                var res = add.DialogResult;

                add.Close();
                add = null;

                if (res == DialogResult.OK)
                {
                    personCreated(patientName);
                }
                else
                {
                    addPersonButtonCancelled();
                }
            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }

        }

        private void btnViewPatientFile_Click(object sender, EventArgs e)
        {
            try
            {
                statusMessagee("View patient file...", true);

                string patientFolder = StaticFunctions.GetSelectedPatientFolder(_currPerson);
                string patientDetailsFilePng = patientFolder + "\\" + StaticFunctions.PatientFilePng;
                string patientDetailsFilePdf = patientFolder + "\\" + StaticFunctions.PatientFilePdf;

                if (File.Exists(patientDetailsFilePng))
                    System.Diagnostics.Process.Start(patientDetailsFilePng);
                else if (File.Exists(patientDetailsFilePdf))
                    System.Diagnostics.Process.Start(patientDetailsFilePdf);
                else
                    MessageBox.Show(patientDetailsFilePng + " does not exist", "Missing Patient File", MessageBoxButtons.OK, MessageBoxIcon.Information);

                statusMessagee("", false);
            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }
        }

        private void btnCompleteConsult_Click(object sender, EventArgs e)
        {
            try
            {
                statusMessagee("Launching Clinical Notes...", true);
                string patientFolder = StaticFunctions.GetSelectedPatientFolder(_currPerson);
                string clinicalNotesFile = patientFolder + "\\" + StaticFunctions.ClinicalNotesFileName;
                if (File.Exists(clinicalNotesFile))
                {
                    StaticFunctions.OpenWordDoc(clinicalNotesFile);
                }
                else
                {
                    string folderName;

                    folderName = _currPerson;

                    folderName = StaticFunctions.PatientsRootFolder + "\\" + _currPerson.Substring(0,1) + "\\" +  folderName;

                    string FileName = folderName + "\\" + StaticFunctions.ClinicalNotesFileName;

                    StaticFunctions.CreateWordDoc(FileName, true);
                }

                statusMessagee("", false);
            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
                statusMessagee("", false);
            }
        }

        private void btnInstructionsForPa_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(StaticFunctions.ClipBoardFile))
                    StaticFunctions.OpenWordDoc(StaticFunctions.ClipBoardFile);
                else
                    MessageBox.Show(StaticFunctions.ClipBoardFile + " file does not exist.", "Missing File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }

        }


        private void btnAddTodaysConsults_Click(object sender, EventArgs e)
        {
            if (StaticFunctions.GetTodaysConsults().Contains(_currPerson))
            {
                MessageBox.Show("The patient is already in todays Patient list", "Patient Already Scheduled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                addPersonToTodayConsults(_currPerson);
            }
        }

        public void ViewPatientFile(string Person)
        {
            CurrentPerson = Person;
            btnViewPatientFile_Click(this, null);
        }

        private void btnOrderCoffee_Click(object sender, EventArgs e)
        {

        }

        private void btnPostOp_Click(object sender, EventArgs e)
        {
            try
            {
                statusMessagee("Adding post Operation document...", true);

                SelectPostOpTemplate post = new SelectPostOpTemplate();
                post.ShowDialog();
                string selectedTemplate = post.SelectedTemplate();

                if (selectedTemplate != null)
                {
                    string patientFolder = StaticFunctions.GetSelectedPatientFolder(_currPerson);
                    int fileNumber = 0;

                    string targetFile;

                    if (Directory.Exists(StaticFunctions.GetSelectedPatientOperationFolder(_currPerson)) == false)
                    {
                        Directory.CreateDirectory(StaticFunctions.GetSelectedPatientOperationFolder(_currPerson));
                    }

                    targetFile = StaticFunctions.GetSelectedPatientOperationFolder(_currPerson) + "\\" + selectedTemplate;
                    targetFile = targetFile.Replace(".doc", fileNumber.ToString() + ".doc");
                    while (File.Exists(targetFile))
                    {
                        fileNumber++;
                        targetFile = StaticFunctions.GetSelectedPatientOperationFolder(_currPerson) + "\\" + selectedTemplate;
                        targetFile = targetFile.Replace(".doc", fileNumber.ToString() + ".doc");
                    }

                    File.Copy(StaticFunctions.TemplatesFolder + "\\" + selectedTemplate, targetFile);
                    Microsoft.Office.Interop.Word.Document doc = StaticFunctions.OpenWordDoc(targetFile);

                    Patient pt = new Patient(_currPerson);

                    StaticFunctions.ReplaceInDoc(doc, "@@FNAME@@", pt.FirstName);
                    StaticFunctions.ReplaceInDoc(doc, "@@LNAME@@", pt.Surname);
                    StaticFunctions.ReplaceInDoc(doc, "@@PN@@", pt.PatientNumber.ToString());

                    addOperationButtonPressed();
                }

                
                statusMessagee("", false);
            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }



        }
    }


}
