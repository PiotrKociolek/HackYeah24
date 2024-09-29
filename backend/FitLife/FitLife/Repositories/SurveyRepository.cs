using FitLife.Data;
using FitLife.Dtos;
using FitLife.entities;
using Microsoft.EntityFrameworkCore;

namespace FitLife.Repositories;

public class SurveyRepository :ISurveyReposiotry
{
    private readonly AppDbContext _context;

    public SurveyRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<List<SurveyDto>> GetHardcodedQuestionAsync()
    {
        var questions = await _context.Questions
            .Where(q => q.IsHardcoded)  // Filtruj po polu IsHardcoded
            .Select(q => new SurveyDto  // Mapuj pytania do SurveyDto
            {
                Id = q.Id,
                Content = q.Content
            })
            .ToListAsync();

        return questions;
    }



    public async Task<Question> GetQuestionByIdAsync(int id)
    {
        var question =  await _context.Questions.FirstOrDefaultAsync(x => x.Id == id);
        if (question != null)
        {
            return question;
        }
        else
        {
            throw new Exception("QUestion with provided Id does not exist");
        }
    }

    public async Task AddQuestionAsync(string content)
    {
        var newquestion = new Question();
        newquestion.Content = content;
        await _context.Questions.AddAsync(newquestion);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateQuestionAsync(string content, int id)
    {
        var question = await _context.Questions.FirstOrDefaultAsync(x => x.Id == id);
        question.Content = content;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteQuestionAsync(int id)
    {
        var question = await _context.Questions.FirstOrDefaultAsync(x => x.Id == id);
    
        if (question == null)
        {
            throw new Exception("Question not found.");
        }

        _context.Questions.Remove(question);
        await _context.SaveChangesAsync();
    }

}