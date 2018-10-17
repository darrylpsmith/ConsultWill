using System;
using System.Collections.Generic;
using System.Text;
using Alchemint.Core;

    public class Patient
    {
        [PrimaryKey]
        public string Id { get; set; }

        [UniqueKey]
        public string PatientNo { get; set; }
        [UniqueKey]
        public string LastName { get; set; }
        [UniqueKey]
        public string FirstName { get; set; }

    }
