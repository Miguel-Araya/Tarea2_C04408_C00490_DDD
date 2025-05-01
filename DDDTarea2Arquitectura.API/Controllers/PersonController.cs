using Application.DTOs;
using Application.Interfaces;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DDDTarea2Arquitectura.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService service;
        public PersonController(IPersonService personService)
        {
            service = personService;
        }

        [HttpGet]
        [Route("GetAllPerson")]
        public async Task<IActionResult> GetAllPerson()
        {
            return Ok(await this.service.selectAll());
        }
        [HttpPost]
        [Route("InsertPerson")]
        public async Task<IActionResult> InsertPerson(PersonDTO personDTO)
        {
            return Ok(await this.service.insertPerson(personDTO));
        }
        [HttpDelete]
        [Route("DeletePerson")]
        public async Task<IActionResult> DeletePerson(string IdCard)
        {
            return Ok(await service.deletePerson(IdCard));
        }
        [HttpPatch]
        [Route("UpdatePerson")]
        public async Task<IActionResult> UpdatePerson(PersonDTO personDTO)
        {
            return Ok(await service.updatePerson(personDTO));
        }

        [HttpGet]
        [Route("GetPersonByID")]
        public async Task<IActionResult> GetPersonByID(string IdCard)
        {
            return Ok(await service.findByIdCard(IdCard));
        }
    }
}
