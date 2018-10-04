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

namespace ConsultWill
{


    public partial class frmConsult : Form
    {

        FileSystemWatcher _coffeeWatcher = null;
        FileSystemWatcher _patientWatcher = null;

        private UserMode _mode = UserMode.Doctor;
        public frmConsult()
        {
            InitializeComponent();
        }

        private void btnConfigure_Click(object sender, EventArgs e)
        {

        }

        private void frmConsult_Load(object sender, EventArgs e)
        {

            try
            {
                bool setStorageLocation = false;
                if (StaticFunctions.StorageFolder == null)
                {
                    setStorageLocation = true;
                }
                else if (StaticFunctions.StorageFolder.Length <= 0)
                {
                    setStorageLocation = true;
                }

                if (setStorageLocation)
                    btnConfigure_Click(this, null);


                this.ActiveControl = txtFindPatient;
                WatchForCoffee();
                
                btnOrderCoffee.Enabled = (StaticFunctions.UserMode == UserMode.Doctor);

                lvwTodaysPatients.View = View.Details;

                LoadTodaysPatients();

                //WatchForChangesToTodaysPatients();
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

        private void btnCreatePatient_Click(object sender, EventArgs e)
        {



            try
            {

                AddPatient add = new AddPatient();
                add.ShowDialog();
                string patientName = add.PatientName;
                var res = add.DialogResult;

                add.Close();
                add = null;

                if (res == DialogResult.OK)
                {
                    txtFindPatient.Text = patientName;
                    if (lstPatients.Items.Count > 0)
                    {
                        lstPatients.SelectedIndex = 0;
                        lstPatients_SelectedValueChanged(this, null);
                    }
                }
            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }

        }

        private void lstPatients_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                btnCompleteConsult.Enabled = (lstPatients.SelectedItem != null);
                btnInstructionsForPa.Enabled = (lstPatients.SelectedItem != null);
                btnAttachFile.Enabled = (lstPatients.SelectedItem != null);
                btnAddTodaysConsults.Enabled = (lstPatients.SelectedItem != null);
                btnViewPatientFile.Enabled = (lstPatients.SelectedItem != null);
                PopulatePatientAttachedFiles();

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
                string patientFolder = GetSelectedPatientFolder();
                string clinicalNotesFile = patientFolder + "\\" + StaticFunctions.ClinicalNotesFileName;
                StaticFunctions.OpenWordDoc(clinicalNotesFile);
            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }

        }

        private string GetSelectedPatientFolder()
        {
            string selPatient = lstPatients.SelectedItem.ToString();
            string subFolder = StaticFunctions.PatientsRootFolder + "\\" + selPatient.Substring(0, 1);
            string patientFolder = subFolder + "\\" + selPatient;
            return patientFolder;
        }

        private string GetSelectedPatientRadiologyFolder()
        {
            string patientFolder = GetSelectedPatientFolder();
            string patientRadFolder = patientFolder + "\\" + @"Radiology & Investigations" + "\\" ;
            return patientRadFolder;
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

        private void btnAttachFile_Click(object sender, EventArgs e)
        {

            try
            {
                string radFolder = GetSelectedPatientRadiologyFolder();
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (!Directory.Exists(radFolder))
                        Directory.CreateDirectory(radFolder);


                    string selectedFile = openFileDialog1.FileName;
                    string fileName = Path.GetFileName(selectedFile);

                    File.Copy(selectedFile, radFolder + fileName);
                    File.Delete(selectedFile);
                    PopulatePatientAttachedFiles();
                }
            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }
        }

        private void lstPatients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void PopulatePatientAttachedFiles()
        {
            lstPatientFiles.Items.Clear();
            if (lstPatients.SelectedIndex >=0)
            {
                string radFolder = GetSelectedPatientRadiologyFolder();
                if (Directory.Exists(radFolder))
                {
                    //var files = Directory.GetFiles(radFolder);
                    DirectoryInfo DirInfo = new DirectoryInfo(radFolder);

                    var filesInOrder = from f in DirInfo.EnumerateFiles()
                                       orderby f.CreationTime descending
                                       select f;

                    foreach (var file in filesInOrder)
                    {
                        string fileName = Path.GetFileName(file.FullName);
                        lstPatientFiles.Items.Add(fileName);
                    }
                }
            }
        }

        private void lstPatientFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstPatientFiles_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                if (lstPatientFiles.SelectedItem != null)
                {
                    if (lstPatientFiles.SelectedItem.ToString().Length != 0)
                    {
                        string radFolder = GetSelectedPatientRadiologyFolder();
                        string file = radFolder + lstPatientFiles.SelectedItem.ToString();
                        System.Diagnostics.Process.Start(file);
                    }
                }
            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }

        }

        public void WatchForCoffee ()
        {

            try
            {
                _coffeeWatcher = new FileSystemWatcher();
                _coffeeWatcher.Path = StaticFunctions.ClipBoardFolder;
                _coffeeWatcher.Filter = StaticFunctions.CoffeeFile;

                // Watch for all changes specified in the NotifyFilters
                //enumeration.
                _coffeeWatcher.NotifyFilter = NotifyFilters.Attributes |
                NotifyFilters.CreationTime |
                NotifyFilters.DirectoryName |
                NotifyFilters.FileName |
                NotifyFilters.LastAccess |
                NotifyFilters.LastWrite |
                NotifyFilters.Security |
                NotifyFilters.Size;

                _coffeeWatcher.Changed += new FileSystemEventHandler(coffeeFileChanged);

                _coffeeWatcher.EnableRaisingEvents = true;
            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }
        }



        private void coffeeFileChanged(object sender, EventArgs e)
        {
            try
            {

                ShowCoffeeImage(picCoffee);

            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }
        }

        delegate void ShowCoffeeImageUpdateText(Control ctl);
        
        private void ShowCoffeeImage(Control ctl)
        {
            if (ctl.InvokeRequired)
            {
                ShowCoffeeImageUpdateText callbackMethod = new ShowCoffeeImageUpdateText(ShowCoffeeImage);
                this.Invoke(callbackMethod, ctl);
            }
            else
            {
                ctl.Visible = true;
            }
        }
        private void todaysPatientsChanged(object sender, EventArgs e)
        {
            try
            {
                LoadTodaysPatients();
            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderCoffee_Click(object sender, EventArgs e)
        {


            try
            {
                _mode = UserMode.Doctor;

                if (_coffeeWatcher != null)
                {
                    _coffeeWatcher.EnableRaisingEvents = false;
                    _coffeeWatcher = null;
                }

                string coffeeFile = StaticFunctions.ClipBoardFolder + "\\" + StaticFunctions.CoffeeFile;

                File.WriteAllText(coffeeFile, DateTime.UtcNow.ToString());

                MessageBox.Show("Sam will be notified of your order for coffee", "Coffee Ordered", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                string patientFolder = GetSelectedPatientFolder();
                string patientDetailsFilePng = patientFolder + "\\" + StaticFunctions.PatientFilePng;
                string patientDetailsFilePdf = patientFolder + "\\" + StaticFunctions.PatientFilePdf;

                if (File.Exists(patientDetailsFilePng))
                    System.Diagnostics.Process.Start(patientDetailsFilePng);
                else if (File.Exists(patientDetailsFilePdf))
                    System.Diagnostics.Process.Start(patientDetailsFilePdf);
                else
                    MessageBox.Show(patientDetailsFilePng + " does not exist", "Missing Patient File", MessageBoxButtons.OK, MessageBoxIcon.Information);            }
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
                        btnViewPatientFile_Click(this, null);
                    }
                }
            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Configure cfg = new Configure();
                cfg.ShowDialog();
                btnOrderCoffee.Enabled = (StaticFunctions.UserMode == UserMode.Doctor);
            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }
        }

        private void btnAddTodaysConsults_Click(object sender, EventArgs e)
        {
            string patient = lstPatients.SelectedItem.ToString();
            if (StaticFunctions.GetTodaysConsults().Contains(patient))
            {
                MessageBox.Show("The patient is already in todays Patient list", "Patient Already Scheduled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string[] pat = new string[] { patient, DateTime.UtcNow.ToString() };
                var itm = new ListViewItem(pat);
                StaticFunctions.AddPatientToTodaysConsults(patient);
                lvwTodaysPatients.Items.Add(itm);
            }
        }

        private void lvwTodaysPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwTodaysPatients.SelectedItems.Count > 0)
                {
                    txtFindPatient.Text = lvwTodaysPatients.SelectedItems[0].Text;
                    txtFindPatient_TextChanged(this, null);
                }

            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }
        }

        private void LoadTodaysPatients()
        {
            lvwTodaysPatients.Items.Clear();
            foreach (var patient in StaticFunctions.GetTodaysConsults())
            {

                string[] pat = new string[] { patient, DateTime.UtcNow.ToString() };
                var itm = new ListViewItem(pat);
                lvwTodaysPatients.Items.Add(itm);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (StaticFunctions.UserMode == UserMode.Doctor)
                {
                    LoadTodaysPatients();
                }
            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }
        }

        private void btnClearTodaysConsults_Click(object sender, EventArgs e)
        {
            try
            {
                StaticFunctions.ClearTodaysPatients();
                lvwTodaysPatients.Items.Clear();
            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }
        }

        private void picCoffee_Click(object sender, EventArgs e)
        {
            picCoffee.Visible = false;
        }

        //public void WatchForChangesToTodaysPatients()
        //{

        //    try
        //    {
        //        if (StaticFunctions.UserMode == UserMode.Doctor)
        //        {
        //            _patientWatcher = new FileSystemWatcher();
        //            _patientWatcher.Path = StaticFunctions.ConsultTrackerFolder;
        //            _patientWatcher.Filter = StaticFunctions.ConsultTrackerTodaysFile;

        //            // Watch for all changes specified in the NotifyFilters
        //            //enumeration.
        //            _patientWatcher.NotifyFilter = NotifyFilters.Attributes |
        //            NotifyFilters.CreationTime |
        //            NotifyFilters.DirectoryName |
        //            NotifyFilters.FileName |
        //            NotifyFilters.LastAccess |
        //            NotifyFilters.LastWrite |
        //            NotifyFilters.Security |
        //            NotifyFilters.Size;

        //            _patientWatcher.Changed += new FileSystemEventHandler(todaysPatientsChanged);

        //            _patientWatcher.EnableRaisingEvents = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        StaticFunctions.HandleException(ex);
        //    }
        //}
    }

}
