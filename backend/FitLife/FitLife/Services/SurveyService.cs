using FitLife.Dtos;
using FitLife.entities;
using FitLife.Repositories;

namespace FitLife.Services;

public class SurveyService : ISurveyService
{
    private readonly ISurveyReposiotry _surveyReposiotry;

    public SurveyService(ISurveyReposiotry surveyReposiotry)
    {
        _surveyReposiotry = surveyReposiotry;
    }

    public async Task<List<SurveyDto>> GetHardcodedQuestionAsync()
    {
        return await _surveyReposiotry.GetHardcodedQuestionAsync();
    }

    public async Task<Question> GetQuestionByIdAsync(int id)
    {
        return await _surveyReposiotry.GetQuestionByIdAsync(id);
    }

    public async Task AddQuestionAsync(string content)
    {
        await _surveyReposiotry.AddQuestionAsync(content);
    }

    public async Task UpdateQuestionAsync(string question, int id)
    {
        await _surveyReposiotry.UpdateQuestionAsync(question, id);
    }

    public async Task DeleteQuestionAsync(int id)
    {
        await _surveyReposiotry.DeleteQuestionAsync(id);
    }
}