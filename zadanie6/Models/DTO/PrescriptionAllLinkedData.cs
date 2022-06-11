using System;
using System.Collections.Generic;

namespace zadanie6.Models.DTO
{
    public class PrescriptionAllLinkedData
    {
        //Dodaj końcówkę, która pozwoli nam pobrać konkretną receptę uwzględniając
        //dane osobowe pacjenta, doktorai listę leków na recepcie.

 

        public DateTime Date { get; set; }
  
        public DateTime DueDate { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public IEnumerable<String> Medicaments { get; set; }
    }
}
