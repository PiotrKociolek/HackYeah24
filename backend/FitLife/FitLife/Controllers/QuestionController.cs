using FitLife.Dtos;
using FitLife.entities;
using FitLife.Entities;
using FitLife.Services;
using Microsoft.AspNetCore.Mvc;

namespace FitLife.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        private readonly ISurveyService _surveyService;

        public SurveyController(ISurveyService surveyService)
        {
            _surveyService = surveyService;
        }

        // GET: api/survey/hardcoded
        [HttpGet("hardcoded")]
        public async Task<ActionResult<IEnumerable<SurveyDto>>> GetHardcodedQuestions()
        {
            var questions = await _surveyService.GetHardcodedQuestionAsync();
            return Ok(questions);
        }

        // GET: api/survey/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Question>> GetQuestionById(int id)
        {
            var question = await _surveyService.GetQuestionByIdAsync(id);

            if (question == null) return NotFound();

            return Ok(question);
        }

        // POST: api/survey
        [HttpPost]
        public async Task<ActionResult> AddQuestion([FromBody] string content)
        {
            if (string.IsNullOrWhiteSpace(content)) return BadRequest("Question content cannot be empty.");

            await _surveyService.AddQuestionAsync(content);

            return Created();
        }

        // PUT: api/survey/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateQuestion(int id, [FromBody] string content)
        {
            if (string.IsNullOrWhiteSpace(content)) return BadRequest("Question content cannot be empty.");

            var question = await _surveyService.GetQuestionByIdAsync(id);

            if (question == null) return NotFound("Question not found.");

            await _surveyService.UpdateQuestionAsync(content, id);

            return Ok();
        }

        // DELETE: api/survey/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuestion(int id)
        {
            var question = await _surveyService.GetQuestionByIdAsync(id);

            if (question == null) return NotFound("Question not found.");

            await _surveyService.DeleteQuestionAsync(id);

            return NoContent();
        }
    }
}
