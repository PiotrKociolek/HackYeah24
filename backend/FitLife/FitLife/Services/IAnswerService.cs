using FitLife.Dtos;
using FitLife.entities;

namespace FitLife.Services;

public interface IAnswerService
{
    Task PostAnswer(AnswerDto answer);
    Task<Answer> GetAnswer(int id);
}