using BibliotecaAPI.Repositories;
using BibliotecaManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        public readonly IAuthorsRepositories _authorsRepositories;

        public AuthorsController(IAuthorsRepositories authorsRepositories)
        {
            _authorsRepositories = authorsRepositories; 
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Autore>>> GetAllAuthors()
        {
            var authors = 
                await _authorsRepositories.GetAllAuthors();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Autore>> GetAuthorByID (int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            
            var author =  await _authorsRepositories.GetAuthorById(id);

            if (author == null)
                return NotFound();

            return Ok(author);
        }

        [HttpPost]
        public async Task<ActionResult<Autore>> CreateAuthor(Autore autore)
        {
            //if (!ModelState.IsValid) return BadRequest(ModelState);
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                return BadRequest($"ModelState not valid: {string.Join(", ", errors)}");
            }
            await _authorsRepositories.AddAuthor(autore);
            return CreatedAtAction(nameof(GetAuthorByID), new { id = autore.Persona.ID }, autore);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Autore>> UpdateAuthor (int id,  Autore autore)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _authorsRepositories.UpdateAuthor(autore);
            return CreatedAtAction(nameof(GetAuthorByID), new {id = autore.Persona.ID}, autore);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Autore>> DeleteAuthor(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            await _authorsRepositories.DeleteAuthor(id);

            return Ok();
        }
    }
}
