using BibliotecaAPI.Repositories;
using BibliotecaManager.Models;
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

        [HttpGet]
        public async Task<ActionResult<Prestito>> GetAllLoans ()
        {
            var prestiti = 
            await _prestitiRepositories.GetAllPresitit();
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Prestito>> GetLoanById(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var loan = await _prestitiRepositories.GetPrestitoById(id);

            if (loan == null) return NotFound();

            return Ok(loan);
        }

        [HttpPost]
        public async Task<ActionResult<Prestito>> CreateNewLoan(Prestito prestito)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                return BadRequest($"ModelState not valid: {string.Join(", ", errors)}");
            }
            await _prestitiRepositories.AddPrestito(prestito);
            return CreatedAtAction(nameof(GetLoanById), new { id = prestito.Id }, prestito);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Prestito>> UpdateLoan(int id, Prestito prestito)
        {
            if (!ModelState.IsValid) return BadRequest();
            await _prestitiRepositories.UpdatePrestito(prestito);
            return CreatedAtAction(nameof(GetLoanById), new { id = prestito.Id }, prestito);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Prestito>> DeleteLoan(int id)
        {
            if (!ModelState.IsValid) { return BadRequest(); }
            await _prestitiRepositories.DeletePrestito(id);
            return Ok();
        }

    }
}
