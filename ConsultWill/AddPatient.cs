using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;

namespace ConsultWill
{
    public partial class AddPatient : Form
    {

        public string PatientName { get; set; }
        public AddPatient()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            int wdToggle = 9999998;
            int wdLine = 5;

            try
            {
                string patient = txtLasteName.Text + ", " + txtFirstName.Text + " " + txtPatientNumber.Text;
                string folderName = StaticFunctions.GetSelectedPatientFolder(patient); //  txtLasteName.Text.Substring(0, 1).ToUpper() + "\\" + txtLasteName.Text + ", " + txtFirstName.Text + " " + txtPatientNumber.Text;

                folderName = folderName.ToUpper();

                if (Directory.Exists(folderName) == false)
                {
                    Directory.CreateDirectory(folderName);
                    string FileName = folderName + "\\" + StaticFunctions.ClinicalNotesFileName;

                    this.Hide();
                    Application.UseWaitCursor = true;
                    Application.DoEvents();

                    var doc = StaticFunctions.CreateWordDoc(FileName, false);


                    doc.Application.Selection.TypeText (Text: txtLasteName.Text + ", " + txtFirstName.Text + " " + txtPatientNumber.Text);
                    doc.Application.Selection.TypeParagraph();
                    doc.Range(0, 0).Select();
                    doc.Application.Selection.MoveEnd (wdLine);
                    
                    doc.Application.Selection.Font.Size = 20;
                    doc.Application.Selection.Font.Bold = wdToggle;

                    doc.Save();
                    doc.Application.Quit(false);
                    Application.UseWaitCursor = false;

                    
                    PatientName = txtLasteName.Text + ", " + txtFirstName.Text + " " + txtPatientNumber.Text;


                    if (txtReferringDocFname.Text.Length > 0 || txtReferringDocLname.Text.Length > 0)
                    {
                        Doctor referringDoc = new Doctor(txtReferringDocLname.Text, txtReferringDocFname.Text, txtReferEmail.Text);
                        StaticFunctions.StoreReferringDoctor(patient, referringDoc);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                }
                else
                {
                    Application.UseWaitCursor = false;
                    MessageBox.Show("That patient already exists", "Patient Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }

        }

        private void AddPatient_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtFirstName;
        }
    }
}
