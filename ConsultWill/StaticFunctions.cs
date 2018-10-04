using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Word;
using System.IO;

namespace ConsultWill
{

    public enum UserMode
    {
        Doctor,
        PA
    }
    public static class StaticFunctions
    {
        public static void HandleException(Exception ex)
        {
            MessageBox.Show(ex.Message, "An Error Occurred ... Call Blackie");
        }

        public static string ClinicalNotesFileName
        {
            get { return "Clinical Notes.doc"; }
        }


        public static string PatientFilePng
        {
            get { return "patient details.png"; }
        }

        public static string PatientFilePdf
        {
            get { return "patient details.pdf"; }
        }


        public static string PatientsRootFolder
        {
            get { return StorageFolder + "\\" + "PATIENTS"; }
        }

        public static void CreateWordDoc(string FileName)
        {
            const int wdFormatDocument = 0;

            Microsoft.Office.Interop.Word.Application wordApp = null;
            try
            {
                wordApp = new Microsoft.Office.Interop.Word.Application();
                var doc = wordApp.Documents.Add();
                //wordApp.Visible = true;
                doc.SaveAs2(FileName, wdFormatDocument);
                doc.Close();
                doc = null;
                wordApp.Quit();
                wordApp = null;
            }
            catch (Exception ex)
            {
                if (wordApp != null)
                {
                    wordApp.Quit(false);
                    wordApp = null;
                }
                StaticFunctions.HandleException(ex);

            }

        }

        public static void OpenWordDoc(string FileName)
        {
            const int wdStory = 6;

            Microsoft.Office.Interop.Word.Application wordApp = null;
            try
            {
                wordApp = new Microsoft.Office.Interop.Word.Application();
                wordApp.Visible = true;
                var doc = wordApp.Documents.Open(FileName);
                doc.Select();
                doc.Activate();
                wordApp.Activate();
                wordApp.Selection.EndKey(wdStory);
                doc = null;
                wordApp = null;
            }
            catch (Exception ex)
            {
                if (wordApp != null)
                {
                    wordApp.Quit(false);
                    wordApp = null;
                }
                StaticFunctions.HandleException(ex);

            }

        }

        public static string ClipBoardFile
        {
            get
            {
                return ClipBoardFolder + "\\" + "Clipboard.docx";
            }
        }

        public static string ClipBoardFolder
        {
            get
            {
                return StorageFolder + "\\" + "CLIPBOARD";
            }
        }

        public static string ConsultTrackerFolder
        {
            get
            {
                return StorageFolder + "\\" + "ConsultTracker";
            }
        }

        public static string ConsultTrackerTodaysFile
        {
            get
            {
                return DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString() + ".txt";
            }
        }

        public static void AddPatientToTodaysConsults (string Patient)
        {
            if (!Directory.Exists(ConsultTrackerFolder))
            {
                Directory.CreateDirectory(ConsultTrackerFolder);
            }
            File.AppendAllText(ConsultTrackerFolder + "\\" + ConsultTrackerTodaysFile, Patient);
            File.AppendAllText(ConsultTrackerFolder + "\\" + ConsultTrackerTodaysFile, @"|");
        }

        public static string [] GetTodaysConsults()
        {
            string[] tdPats;
            if (Directory.Exists(ConsultTrackerFolder))
            {
                if (File.Exists (ConsultTrackerFolder + "\\" + ConsultTrackerTodaysFile))
                {
                    string todaysPatients = File.ReadAllText(ConsultTrackerFolder + "\\" + ConsultTrackerTodaysFile);
                    tdPats =  todaysPatients.Split('|');

                    return tdPats.Take(tdPats.Count() - 1).ToArray<string>();
                    
                }
                else
                {
                    return new string[] { };
                }
            }
            else
            {
                return new string[] { };
            }
            
        }

        public static void ClearTodaysPatients()
        {
            if (Directory.Exists(ConsultTrackerFolder))
            {
                if (File.Exists(ConsultTrackerFolder + "\\" + ConsultTrackerTodaysFile))
                {
                    File.Delete(ConsultTrackerFolder + "\\" + ConsultTrackerTodaysFile);
                }
                  
            }

        }
        public static string RootFolder
        {
            get
            {
                return StorageFolder + "\\" ;
            }
        }

        public static string CoffeeFile
        {
            get
            {
                return  "Coffee.txt";
            }
        }

        public static UserMode UserMode
        {
            get { return (UserMode)Properties.Settings.Default.UserMode; }
            set {
                Properties.Settings.Default.UserMode = (int)value;
                Properties.Settings.Default.Save();
            }
        }

        public static string StorageFolder
        {
            get
            {
                return Properties.Settings.Default.StorageFolder;
            }
            set
            {
                Properties.Settings.Default.StorageFolder = value;
                Properties.Settings.Default.Save();
            }
        }


    }
}
