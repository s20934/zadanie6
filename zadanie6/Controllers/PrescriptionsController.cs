using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using zadanie6.Models;
using zadanie6.Services;

namespace zadanie6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionsController : ControllerBase
    {
        private readonly IDbService _dbService;
        public PrescriptionsController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet("{idPrescription}")]
        public async Task<IActionResult> GetDoctors(int idPrescription)
        {
            Console.WriteLine("Otrzymałem zapytanie na endpoint /prescriptions");
            
            var cos =  await _dbService.GetAllInformations(idPrescription);

            return Ok(cos);
        }
       
       



    }
}