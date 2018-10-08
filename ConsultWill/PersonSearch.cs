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
    public partial class PersonSearch : UserControl
    {

        // declare delegate 
        public delegate void SelectedPersonChanged (string Patient, bool NoSelection);

        //declare event of type delegate
        public event SelectedPersonChanged selectedPersonChanged;


        // declare delegate 
        public delegate void PersonDoubleClicked(string Patient);

        //declare event of type delegate
        public event PersonDoubleClicked personDoubleClicked;

        public PersonSearch()
        {
            InitializeComponent();
        }

        public void SetSearch(string Search)
        {
            txtFindPatient.Text = Search;
            txtFindPatient_TextChanged(this, null);
        }
        private void txtFindPatient_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LoadPatientList();
            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }
        }

        private void LoadPatientList()
        {
            lstPatients.Items.Clear();
            lstPatients.SelectedItem = null;
            lstPatients_SelectedValueChanged(this, null);
            if (txtFindPatient.Text.Trim().Length <= 0)
            {
                return;
            }
            else
            {
                string subFolder = StaticFunctions.PatientsRootFolder + @"\" + txtFindPatient.Text.Substring(0, 1);
                string search = txtFindPatient.Text + "*";

                if (Directory.Exists(subFolder))
                {
                    string[] dirs = Directory.GetDirectories(subFolder, search);

                    foreach (var dir in dirs)
                    {
                        string lastFolderName = Path.GetFileName(dir);
                        lstPatients.Items.Add(lastFolderName);
                    }

                    if (lstPatients.Items.Count == 1)
                    {
                        lstPatients.SelectedIndex = 0;
                        lstPatients_SelectedValueChanged(this, null);
                    }

                }
                else
                {
                    return;
                }
            }

            //public void lstPatients_SelectedValueChanged(object sender, EventArgs e)
            //{


            //}

        }

        private void lstPatients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstPatients_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                bool noneSelected = (lstPatients.SelectedItem == null);
                string patient = "";
                if (!noneSelected)
                    patient = lstPatients.SelectedItem.ToString();


                selectedPersonChanged( patient, noneSelected);

                //btnCompleteConsult.Enabled = (lstPatients.SelectedItem != null);
                //btnInstructionsForPa.Enabled = (lstPatients.SelectedItem != null);
                //btnAttachFile.Enabled = (lstPatients.SelectedItem != null);
                //btnAddTodaysConsults.Enabled = (lstPatients.SelectedItem != null);
                //btnViewPatientFile.Enabled = (lstPatients.SelectedItem != null);
                //PopulatePatientAttachedFiles();

            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }
        }


        private void lstPatients_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (lstPatients.SelectedItem != null)
                {
                    if (lstPatients.SelectedItem.ToString().Length != 0)
                    {
                        personDoubleClicked(lstPatients.SelectedItem.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }
        }

        private void lblFindPatient_Click(object sender, EventArgs e)
        {

        }

        private void PersonSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
