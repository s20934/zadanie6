using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using zadanie6.Models;
using zadanie6.Services;

namespace zadanie6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDbService _dbService;
        public DoctorsController(IDbService dbService)
        {
            _dbService = dbService;
        }
        [HttpGet]
        public async Task<IActionResult> GetDoctors()
        {
            var doctors = await _dbService.GetDoctors();
            return Ok(doctors);
        }
        [HttpPost]
        public async Task<IActionResult> AddDoctor(Doctor doctor)
        {
            var addedDoctor = _dbService.AddDoctor(doctor);
            if (addedDoctor == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            else
            {
                return Ok(addedDoctor);
            }
        }
        [HttpDelete("{idDoctor}")]
        public async Task<IActionResult> DeleteDoctor(int idDoctor)
        {
           
            if (_dbService.DeleteDoctor(idDoctor))
            {
                return Ok("Usuniety");
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPut("{idDoctor}")]
        public async Task<IActionResult> EditDoctor(int idDoctor, Doctor doctor)
        {
            var updatedDoctor = _dbService.EditDoctor(idDoctor, doctor);
            if (updatedDoctor == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            else
            {
                return Ok(updatedDoctor);
            }
        }
    }
}

