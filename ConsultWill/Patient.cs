using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsultWill
{
    public class Patient : Person
    {
        public Patient(string patientString)
        {
            
            PatientNumber = patientString.Substring( patientString.LastIndexOf(' '));
            base.Surname = patientString.Substring(0, patientString.IndexOf(','));
            base.FirstName = patientString.Substring(patientString.IndexOf(',') + 1);
            base.FirstName = base.FirstName.Substring(0, base.FirstName.LastIndexOf(' ')).Trim();
        }

        public string PatientNumber { get; set; }
    }

}
