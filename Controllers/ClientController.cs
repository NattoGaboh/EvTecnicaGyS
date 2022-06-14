using EvTecnicaGyS.Domain.IServices;
using EvTecnicaGyS.Domain.Models;
using EvTecnicaGyS.Validator;
using EvTecnicaGyS.Helpers;
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
        readonly ClientValidator clientValidator = new ClientValidator();
        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }
        // GET: api/<ClientController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var list = await _clientService.GetListClient();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<ClientController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Client client)
        {
            try
            {
                client.CodCliente = client.CodCliente.Length < 10 ? Helper.FillString(client.CodCliente, '0', 10, true) : client.CodCliente;
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
        [HttpPut("{codClient}")]
        public async Task<IActionResult> Put(string codClient,[FromBody] Client client)
        {
            try
            {
                codClient = codClient.Length < 10 ? Helper.FillString(codClient, '0', 10, true) : codClient;
                client.CodCliente = client.CodCliente.Length < 10 ? Helper.FillString(client.CodCliente, '0', 10, true) : client.CodCliente;
                if (!codClient.Equals(client.CodCliente))
                {
                    return BadRequest(new { message = "Identificadores no concuerdan." });
                }
                var result = clientValidator.Validate(client);
                if (!result.IsValid)
                {
                    foreach (var item in result.Errors)
                    {
                        return BadRequest(new { message = item.ErrorMessage });
                    }
                }
                bool exists = await _clientService.ValidateExistence(codClient);
                if (!exists)
                {
                    return BadRequest(new { message = "Cliente no existe." });
                }
                await _clientService.UpdateClient(client);
                return Ok(new { message = "Cliente Actualizado." });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{codClient}")]
        public async Task<IActionResult> Delete(string codClient)
        {
            try
            {
                codClient = codClient.Length < 10 ? Helper.FillString(codClient, '0', 10, true) : codClient;
                var client = await _clientService.ValidateClient(codClient);
                if (client==null)
                {
                    return BadRequest(new { message = "No se encontró cliente." });
                }
                await _clientService.DeleteClient(client);
                return Ok(new {message="Cliente eliminado." });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
