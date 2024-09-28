using FitLife.Dto;
using FitLife.entities;
using FitLife.Entities.Services;
using Microsoft.AspNetCore.Mvc;

namespace FitLife.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialistController : ControllerBase
    {
        private readonly ISpecialistsService _specialistsService;

        public SpecialistController(ISpecialistsService specialistsService)
        {
            _specialistsService = specialistsService;
        }

        // Dodawanie specjalisty
        [HttpPost]
        public async Task<IActionResult> AddSpecialistAsync(UpdateSpecialistDto specialist)
        {
            await _specialistsService.CreateSpecialist(specialist);
            // Zwracamy Created z URI i utworzonym specjalistą
            return Created();
        }

        // Edycja specjalisty
        [HttpPut("{id}")]
        public async Task<IActionResult> EditSpecialistAsync([FromBody] UpdateSpecialistDto specialist, int id)
        {
            await _specialistsService.EditSpecialist(specialist, id);
            return Ok("Specialist updated successfully.");
        }

        // Usuwanie specjalisty
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSpecialistAsync(int id)
        {
            await _specialistsService.DeleteSpecialist(id);
            return Ok($"Specialist with ID {id} has been deleted.");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSpecialistByIdAsync(int id)
        {
            var specialist = await _specialistsService.GetSpecialistById(id);
            if (specialist == null)
            {
                return NotFound($"Specialist with ID {id} not found.");
            }
            return Ok(specialist);
        }
        [HttpGet("all")]
        public async Task<IActionResult> GetAllSpecialists()
        {
            var specialists = await _specialistsService.GetAllSpecialists();
            return Ok(specialists);
        }

    }
}
    

