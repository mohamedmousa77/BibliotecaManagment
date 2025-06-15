using BibliotecaAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrestitoController : ControllerBase
    {
        public readonly IPrestitiRepositories _prestitiRepositories;

        public PrestitoController(IPrestitiRepositories prestitiRepositories)
        {
            _prestitiRepositories = prestitiRepositories;    
        }
    }
}
