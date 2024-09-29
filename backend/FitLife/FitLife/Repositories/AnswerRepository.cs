using FitLife.Data;
using FitLife.Dtos;
using FitLife.entities;
using FitLife.Enum;
using Microsoft.AspNetCore.Http.HttpResults;

namespace FitLife.Repositories;

public class AnswerRepository : IAnswerRepository
{
    private readonly AppDbContext _context;

    public AnswerRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task PostAnswer(AnswerDto answer)
    {
        // Fetch the related question
        var question = await _context.Questions.FindAsync(answer.QuestionId);
        if (question == null)
        {
            throw new Exception("Question not found.");
        }

        // Validate for predefined answers (assuming this applies to a specific question)
        if (question.IsPredefined && !UserCategory.AllowedAnswerQ1.Contains(answer.Content))
        {
            var allowedAnswers = string.Join(", ", UserCategory.AllowedAnswerQ1);
            throw new Exception($"Invalid answer. Allowed answers for question 1 are: {allowedAnswers}");
        }

        // Map AnswerDto to Answer entity
        var newAnswer = new Answer
        {
            Content = answer.Content,
            QuestionId = answer.QuestionId
            
        };

        // Add the answer entity to the database
        _context.Answers.Add(newAnswer);
        await _context.SaveChangesAsync();
    }


    public async Task<Answer> GetAnswer(int id)
    {
        var answer = await _context.Answers.FindAsync(id);
    
        if (answer == null)
        {
            throw new KeyNotFoundException($"Answer with ID {id} not found."); // Rzuca wyjątek, gdy odpowiedź nie istnieje
        }

        return answer; // Zwraca znalezioną odpowiedź
    }


}