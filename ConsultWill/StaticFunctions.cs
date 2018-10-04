using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Word;

namespace ConsultWill
{
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


        public static string PatientFile
        {
            get { return "patient details.png"; }
        }

        public static string PatientsRootFolder
        {
            get { return Properties.Settings.Default.StorageFolder + "\\" + "PATIENTS"; }
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
                return Properties.Settings.Default.StorageFolder + "\\" + "CLIPBOARD";
            }
        }

        public static string RootFolder
        {
            get
            {
                return Properties.Settings.Default.StorageFolder + "\\" ;
            }
        }

        public static string CoffeeFile
        {
            get
            {
                return  "Coffee.txt";
            }
        }
    }
}
