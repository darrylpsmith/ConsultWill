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

            try
            {
                string folderName = txtLasteName.Text.Substring(0, 1).ToUpper() + "\\" + txtLasteName.Text + ", " + txtFirstName.Text + " " + txtPatientNumber.Text;

                folderName = folderName.ToUpper();

                folderName = StaticFunctions.PatientsRootFolder + "\\" + folderName;

                if (Directory.Exists(folderName) == false)
                {
                    Directory.CreateDirectory(folderName);
                    string FileName = folderName + "\\" + StaticFunctions.ClinicalNotesFileName;

                    this.Hide();
                    Application.UseWaitCursor = true;
                    Application.DoEvents();
                    StaticFunctions.CreateWordDoc(FileName);
                    Application.UseWaitCursor = false;
                    PatientName = txtLasteName.Text + ", " + txtFirstName.Text + " " + txtPatientNumber.Text;
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


    }
}
