using BibliotecaAPI.Repositories;
using BibliotecaManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        public readonly IClientsRepositories _clientsRepositories;

        public ClientsController(IClientsRepositories clientsRepositories)
        {
            _clientsRepositories = clientsRepositories;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetAllClients()
        {
            var clients = 
                await _clientsRepositories.GetAllClients();
            return Ok(clients);
        }
        [HttpPost]
        public async Task<ActionResult<Cliente>> CreateClient(Cliente client)
        {
            await _clientsRepositories.AddClient(client);
            return Ok(client);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetClientById (int id)
        {
            await _clientsRepositories.GetClientById(id);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Cliente>> UpdateClient(int id, Cliente client)
        {
            await _clientsRepositories.UpdateClient(client);
            return CreatedAtAction(nameof(UpdateClient), new {id = client.Persona.ID}, client);
        }

        [HttpDelete]
        public async Task<ActionResult<Cliente>> DeleteClient(int id)
        {
            await _clientsRepositories.DeleteClient(id);
            return Ok();
        }
        
    }
}
