using System;
using System.Collections.Generic;
using System.Text;
using Alchemint.Core;

namespace Alchemed.DataModel
{
    public class PatientEvent
    {
        [PrimaryKey]
        public string Id { get; set; }

        public string PatientId { get; set; }

        public DateTime Date { get; set; }


        public string Description { get; set; }


        void x ()
        {
            Alchemint.DataModel.
        }

    }
}