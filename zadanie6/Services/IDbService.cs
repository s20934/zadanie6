using System.Collections.Generic;
using System.Threading.Tasks;
using zadanie6.Models;
using zadanie6.Models.DTO;

namespace zadanie6.Services
{
    public interface IDbService
    {
        Task<IEnumerable<SomeSortOfDoctor>> GetDoctors();
        Doctor AddDoctor(Doctor doctor);
        Doctor EditDoctor(int idDoctor, Doctor doctor);
        bool DeleteDoctor(int idDoctor);
        Task<IEnumerable<PrescriptionAllLinkedData>> GetAllInformations(int idPrescription);
    }
}
