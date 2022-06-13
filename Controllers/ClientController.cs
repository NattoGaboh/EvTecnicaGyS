using EvTecnicaGyS.Domain.IServices;
using EvTecnicaGyS.Domain.Models;
using EvTecnicaGyS.Validator;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EvTecnicaGyS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        public readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }
        //// GET: api/<ClientController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<ClientController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<ClientController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Client client)
        {
            try
            {
                ClientValidator clientValidator = new ClientValidator();
                var result = clientValidator.Validate(client);
                if (!result.IsValid)
                {
                    foreach (var item in result.Errors)
                    {
                        return BadRequest( new { message = item.ErrorMessage });
                    }
                }
                await _clientService.SaveClient(client);
                return Ok(new { message = "Cliente Registrado." });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string codClient, [FromBody] Client client)
        {
            try
            {

                await _clientService.UpdateClient(client);
                return Ok(new { message = "Cliente Actualizado." });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
