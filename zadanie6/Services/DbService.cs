using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zadanie6.Models;
using zadanie6.Models.DTO;

namespace zadanie6.Services
{
    public class DbService : IDbService
    {

        private readonly MainDbContext _dbContext;
        public DbService(MainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Doctor AddDoctor(Doctor doctor)
        {

            var AddedDoctor = new Doctor(doctor.IdDoctor, doctor.FirstName, doctor.LastName, doctor.Email);
                _dbContext.Add<Doctor>(AddedDoctor);
                _dbContext.SaveChanges();

                return doctor;
            
        }

        public bool DeleteDoctor(int idDoctor)
        {
            try
            {
                if (_dbContext.Doctors.Any(e => e.IdDoctor == idDoctor))
                {

                    Console.WriteLine("Usuwam");

                    _dbContext.Remove(_dbContext.Doctors.Single(e => e.IdDoctor == idDoctor));
                    _dbContext.SaveChanges();
                    return true;
                    
                }
                else
                {
                    Console.WriteLine("Nie znalazlem takiego");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Blad");
                return false;
            }
        }

        public Doctor EditDoctor(int idDoctor, Doctor doctor)
        {
            try
            {
                var result = _dbContext.Doctors.Single(p => p.IdDoctor == idDoctor);
                if (result == null)
                {
                    Console.WriteLine("Nie ma takiego ziomka");
                    return null;
                }
                else
                {


                    Console.WriteLine("Znalazłem i updatuje");
                    result.FirstName = doctor.FirstName;
                    result.LastName = doctor.LastName;
                    result.Email = doctor.Email;
                    _dbContext.SaveChanges();


                    return result;
                }
            }catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IEnumerable<PrescriptionAllLinkedData>> GetAllInformations(int idPrescription)
        {
            return await _dbContext.Prescriptions
                 .Where(p => p.IdPrescription == idPrescription)
                 .Include(e => e.Doctor)
                 .Include(e => e.Patient)
                 .Include(e => e.Prescriptions_Medicament)
                 .Select(e => new PrescriptionAllLinkedData
                 {
                     Date = e.Date,
                     DueDate = e.DueDate,
                     Doctor = e.Doctor,
                     Patient = e.Patient,
                     Medicaments = e.Prescriptions_Medicament.Select(p => p.Medicament.Name)
                 }).ToListAsync();


        }

        public async Task<IEnumerable<SomeSortOfDoctor>> GetDoctors()
        {
            Console.WriteLine("Db service dostał info");

            return await _dbContext.Doctors
                .Select(p => new SomeSortOfDoctor
                {
                  FirstName = p.FirstName,
                  LastName = p.LastName,
                  Email = p.Email

                }).ToListAsync();
        }
    }
}
