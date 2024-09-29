using FitLife.Dtos;
using FitLife.entities;
using FitLife.Repositories;

namespace FitLife.Services;

public class AnswerService : IAnswerService
{
    private readonly IAnswerRepository _answerRepository;

    public AnswerService(IAnswerRepository answerRepository)
    {
        _answerRepository = answerRepository;
    }
    public async  Task PostAnswer(AnswerDto answer)
    {
        await _answerRepository.PostAnswer(answer);
    }

    public async Task<Answer> GetAnswer(int id)
    {
       return await _answerRepository.GetAnswer(id);
    }
}