using FitLife.Dtos;
using FitLife.entities;
using FitLife.Services;
using Microsoft.AspNetCore.Mvc;

namespace FitLife.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AnswerControler : ControllerBase
{
    private readonly IAnswerService _answerService;

    public AnswerControler(IAnswerService answerService)
    {
        _answerService = answerService;
    }
    [HttpPost]
    public async Task PostAnswerASync(AnswerDto answer)
    {
        _answerService.PostAnswer(answer);
        Created();
    }

    [HttpGet]
    public async Task GetAnswerAsync(int id)
    {
        _answerService.GetAnswer(id);
        Ok();
    }
}