using FitLife.Dtos;
using FitLife.entities;

namespace FitLife.Repositories;

public interface IAnswerRepository
{
    Task PostAnswer(AnswerDto answer);
    Task<Answer > GetAnswer(int id);
}