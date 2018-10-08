﻿using System;
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

        public static Microsoft.Office.Interop.Word.Document OpenWordDoc(string FileName)
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
                return doc;
            }
            catch (Exception ex)
            {
                if (wordApp != null)
                {
                    wordApp.Quit(false);
                    wordApp = null;
                }
                StaticFunctions.HandleException(ex);
                return null;
            }

        }


        public static void ReplaceInDoc(Microsoft.Office.Interop.Word.Document  theDoc, string ReplaceIt, string ReplaceWith)
        {
            Microsoft.Office.Interop.Word.WdFindWrap wdFindAsk = (Microsoft.Office.Interop.Word.WdFindWrap) 2;

            Microsoft.Office.Interop.Word.Application wordApp = theDoc.Application;

            var wdReplaceAll = 2;

            wordApp.Selection.WholeStory();
            wordApp.Selection.Find.ClearFormatting();
            wordApp.Selection.Find.Replacement.ClearFormatting();
            wordApp.Selection.Find.Text = ReplaceIt;
            wordApp.Selection.Find.Replacement.Text = ReplaceWith;
            wordApp.Selection.Find.Forward = true;
            wordApp.Selection.Find.Wrap = wdFindAsk;
            wordApp.Selection.Find.Format = false;
            wordApp.Selection.Find.MatchCase = false;
            wordApp.Selection.Find.MatchWholeWord = false;
            wordApp.Selection.Find.MatchWildcards = false;
            wordApp.Selection.Find.MatchSoundsLike = false;
            wordApp.Selection.Find.MatchAllWordForms = false;

            wordApp.Selection.Find.Execute(Replace: wdReplaceAll);
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

        public static string TemplatesFolder
        {
            get
            {
                return StorageFolder + "\\" + "TEMPLATES";
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

        public static string DoctorMessageFile
        {
            get
            {
                return "Doctor_Message.txt";
            }
        }

        public static string PAMessageFile
        {
            get
            {
                return "PA_Message.txt";
            }
        }

        public static string DoctorMessage
        {
            get
            {
                string messageFile = StaticFunctions.ConsultTrackerFolder + "\\" + StaticFunctions.DoctorMessageFile;
                File.Copy(messageFile, messageFile + "xxx");
                string msg =  File.ReadAllText(messageFile + "xxx");
                File.Delete(messageFile + "xxx");
                return msg;
            }
        }

        public static string PAMessage
        {
            get
            {
                string messageFile = StaticFunctions.ConsultTrackerFolder + "\\" + StaticFunctions.PAMessageFile;
                File.Copy(messageFile, messageFile + "xxx");
                string msg = File.ReadAllText(messageFile + "xxx");
                File.Delete(messageFile + "xxx");
                return msg;
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

        public static List<DocumentAssignmentFolder> PatientDocumentConfig ()
        {
            List<DocumentAssignmentFolder> folders = new List<DocumentAssignmentFolder>();
            folders.Add(PatientConsultDocsConfig);
            folders.Add(PatientInvestigationsAndRadiologyDocsConfig);
            folders.Add(PatientProblemQuestionaireDocsConfig);
            folders.Add(PatientPreOperationsDocsConfig);
            folders.Add(PatientPostOperationsDocsConfig);
            return folders;
        }

        private static DocumentAssignmentFolder PatientPreOperationsDocsConfig
        {
            get {
                return new DocumentAssignmentFolder {
                    DisplayName = "Pre Surgical Operations",
                    FolderName = "PreOperations",
                    RemoveSourceFilesWhenAssigningToFolder = true,
                    ParentFolderName =  "[PATIENT]" } ;
                }
        }

        private static DocumentAssignmentFolder PatientPostOperationsDocsConfig
        {
            get
            {
                return new DocumentAssignmentFolder
                {
                    DisplayName = "Post Surgical Operations",
                    FolderName = "Operations",
                    RemoveSourceFilesWhenAssigningToFolder = true,
                    ParentFolderName = "[PATIENT]"
                };
            }
        }
        private static DocumentAssignmentFolder PatientConsultDocsConfig
        {
            get
            {
                return new DocumentAssignmentFolder
                {
                    DisplayName = "Consults",
                    FolderName = "Correspondence & Notes",
                    RemoveSourceFilesWhenAssigningToFolder = true,
                    ParentFolderName = "[PATIENT]"
                };
            }
        }

        private static DocumentAssignmentFolder PatientInvestigationsAndRadiologyDocsConfig
        {
            get
            {
                return new DocumentAssignmentFolder
                {
                    DisplayName = "Radiology & Investigations",
                    FolderName = "Radiology & Investigations",
                    RemoveSourceFilesWhenAssigningToFolder = true,
                    ParentFolderName = "[PATIENT]"
                };
            }
        }

        private static DocumentAssignmentFolder PatientProblemQuestionaireDocsConfig
        {
            get
            {
                return new DocumentAssignmentFolder
                {
                    DisplayName = "Patient Questionaires",
                    FolderName = "Patient Questionaires",
                    RemoveSourceFilesWhenAssigningToFolder = true,
                    ParentFolderName = "[PATIENT]"
                };
            }
        }

        public static string GetSelectedPatientFolder(string Person)
        {
            string selPatient = Person;
            string subFolder = StaticFunctions.PatientsRootFolder + "\\" + selPatient.Substring(0, 1);
            string patientFolder = subFolder + "\\" + selPatient;
            return patientFolder;
        }

        public static string GetSelectedPatientDocumentFolder(string Person, string Subfolder)
        {
            string patientFolder = StaticFunctions.GetSelectedPatientFolder(Person);
            string patientRadFolder = patientFolder + "\\" +  Subfolder + "\\"; // "\\" + @"Radiology & Investigations" + "\\";
            return patientRadFolder;
        }

        public static string GetSelectedPatientOperationFolder(string Person)
        {
            string selPatient = Person;
            string subFolder = StaticFunctions.PatientsRootFolder + "\\" + selPatient.Substring(0, 1) ;
            string patientFolder = subFolder + "\\" + selPatient + "\\Operations";
            return patientFolder;
        }


        public static string GetSelectedPatientCommentFolder(string Person)
        {
            string selPatient = Person;
            string subFolder = StaticFunctions.PatientsRootFolder + "\\" + selPatient.Substring(0, 1);
            string patientFolder = subFolder + "\\" + selPatient + "\\Comments";
            return patientFolder;
        }

    }
}
