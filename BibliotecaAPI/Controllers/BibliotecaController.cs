using BibliotecaAPI.Repositories;
using BibliotecaManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BibliotecaController : ControllerBase
    {
        public readonly IBibliotecaRepositories _bibliotecaRepositories;

        public BibliotecaController(IBibliotecaRepositories bibliotecaRepositories) 
        {
            _bibliotecaRepositories = bibliotecaRepositories;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetAllClients() 
        { 
            var clientsList = 
                await _bibliotecaRepositories.GetAllClients();
            return Ok(clientsList);
        }
    }
}
