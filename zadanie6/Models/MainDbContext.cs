using Microsoft.EntityFrameworkCore;
using System;

namespace zadanie6.Models
{
    public class MainDbContext : DbContext
    {
        protected MainDbContext()
        {

        }
        public MainDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
       public DbSet<Medicament> Medicaments { get; set; }  
        public DbSet<Prescription_Medicament> Prescription_Medicaments { get; set; }    

       protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Patient>(p =>
            {
                p.HasData(
                    new Patient { IdPatient = 1, FirstName = "Marek",LastName = "pijak",BirthDay = DateTime.UtcNow },
                    new Patient { IdPatient = 2, FirstName = "Sylwia",LastName = "Pajonk",BirthDay = DateTime.UtcNow }
                    );

            });

            modelbuilder.Entity<Doctor>(d =>
            {
                d.HasData(
                    new Doctor { IdDoctor = 1, FirstName = "Marek", LastName = "pijak",  Email = "gwiaz@o2.pl"},
                    new Doctor { IdDoctor = 2, FirstName = "Elzo", LastName = "Monzales",  Email = "swist@o2.pl"}
                    
                    );

            });

            modelbuilder.Entity<Prescription>(p =>
            {
                p.HasData(
                   new Prescription { IdPrescription = 1, Date = DateTime.UtcNow, DueDate = DateTime.Parse("2022-10-10"), IdDoctor = 1, IdPatient =2},
                   new Prescription { IdPrescription = 2, Date = DateTime.UtcNow, DueDate = DateTime.Parse("2022-10-10"), IdDoctor = 2, IdPatient =1}

                    );

            });

            modelbuilder.Entity<Medicament>(p =>
            {
                p.HasData(
                   new Medicament { IdMedicament = 1, Name = "Syrop", Description = "Opis", Type = "Jakis tam zilowoy"},
                   new Medicament { IdMedicament = 2, Name = "Krople", Description = "Na chore oczy", Type = "Jakis tam zilowoy",},
                   new Medicament { IdMedicament = 3, Name = "Wziewy", Description = "Na chore oczy", Type = "Jakis tam zilowoy",},
                   new Medicament { IdMedicament = 4, Name = "Plastry", Description = "Na chore oczy", Type = "Jakis tam zilowoy",},
                   new Medicament { IdMedicament = 5, Name = "Tabletki", Description = "Na chore oczy", Type = "Jakis tam zilowoy",}

                    );

            });

            modelbuilder.Entity<Prescription_Medicament>(p =>
            {
                p.HasKey(c => new { c.IdPrescription, c.IdMedicament });

                p.HasData(
                    new Prescription_Medicament { IdPrescription = 1, IdMedicament = 1,Dose = 2,Details = "cos tam"},
                    new Prescription_Medicament { IdPrescription = 1, IdMedicament = 2,Dose = 2,Details = "cos tam"},
                    new Prescription_Medicament { IdPrescription = 1, IdMedicament = 3,Dose = 2,Details = "cos tam"},
                    new Prescription_Medicament { IdPrescription = 1, IdMedicament = 4,Dose = 2,Details = "cos tam"},
                    new Prescription_Medicament { IdPrescription = 1, IdMedicament = 5,Dose = 2,Details = "cos tam"},
                    new Prescription_Medicament { IdPrescription = 2, IdMedicament = 2,Dose = 5,Details = "cos tam i troche wiecej"}
                    );
            });
              
//
        }
    }
}
