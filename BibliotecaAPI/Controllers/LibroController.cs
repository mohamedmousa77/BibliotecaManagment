using BibliotecaAPI.Repositories;
using BibliotecaManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController: ControllerBase
    {
        public readonly ILibriRepositories _libriRepositories;

        public LibroController (ILibriRepositories libriRepositories)
        {
            _libriRepositories = libriRepositories;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Libro>>> GetAllBooks()
        {
            var books = await _libriRepositories.GetAllLibri();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Libro>> GetBookById(int id)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);

            var book = await _libriRepositories.GetLibroById(id);

            if(book == null)  return NotFound(); 

            return Ok(book);
        }

        [HttpPost]
        public async Task<ActionResult<Libro>> CreateNewBook(Libro libro)
        {
            if(!ModelState.IsValid) 
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                return BadRequest($"ModelState not valid: {string.Join(", ", errors)}");
            }
            libro.Id = await _libriRepositories.GenerateUniqueID();
            await _libriRepositories.AddLibro(libro);
            return CreatedAtAction(nameof(GetBookById), new { id = libro.Id}, libro);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Libro>> UpdateBook (int id, Libro libro)
        {
            if(!ModelState.IsValid) return BadRequest();
            await _libriRepositories.UpdateLibro(libro);
            return CreatedAtAction("nameof(GetBookById)", new {id = libro.Id}, libro);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Libro>> DeleteBook (int id)
        {
            if(!ModelState.IsValid) { return BadRequest(); }
            await _libriRepositories.DeleteLibro(id);
            return Ok();
        }
    }
}
