﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace zadanie6.Models
{
    public class Patient
    {
        [Key]
        public int IdPatient { get; set; }  
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        public DateTime  BirthDay { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }    
    }
}
