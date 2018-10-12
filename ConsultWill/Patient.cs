using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsultWill
{
    public class Patient 
    {

        public string PatientNumber { get; set; }

        public string Surname { get; set; }
        public string FirstName { get; set; }
        public Patient(string patientString)
        {
            
            PatientNumber = patientString.Substring( patientString.LastIndexOf(' '));
            Surname = patientString.Substring(0, patientString.IndexOf(','));
            FirstName = patientString.Substring(patientString.IndexOf(',') + 1);
            FirstName = FirstName.Substring(0, FirstName.LastIndexOf(' ')).Trim();
        }

        
    }

}
