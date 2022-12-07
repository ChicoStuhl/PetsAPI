using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using PetApp.Core.Entities;
using PetApp.Core.Interfaces.Services;
using PetApp.Infra.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetsApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspeciesController : ControllerBase
    {
        private readonly IEspecieService _especieService;

        public EspeciesController(IEspecieService especieService)
        {
            _especieService = especieService;
        }


        // GET: api/<EspeciesController>
        [HttpGet]
        public async Task<ActionResult<Especie>> GetAll(CancellationToken cancellationToken)
        {
            var especies = await _especieService.GetAll(cancellationToken);
            return Ok(especies);
        }
             
        // GET api/<EspeciesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        

        // POST api/<EspeciesController>
        [HttpPost]
        public void Post([FromBody] EspecieRepository especieRepository )
        {
            
        }

        // PUT api/<EspeciesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EspeciesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
