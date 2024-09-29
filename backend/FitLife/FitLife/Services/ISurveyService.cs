using FitLife.Dtos;
using FitLife.entities;

namespace FitLife.Services;

public interface ISurveyService
{
    Task<List<SurveyDto>> GetHardcodedQuestionAsync();
    Task<Question>GetQuestionByIdAsync(int id);
    Task AddQuestionAsync(string content);
    Task UpdateQuestionAsync(string question, int id);
    Task DeleteQuestionAsync(int id);
}