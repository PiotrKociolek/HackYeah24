
using FitLife.Data;
using FitLife.Dto;
using FitLife.entities;
using Microsoft.EntityFrameworkCore;

namespace FitLife.Entities.Services
{

    public class SpecialistService : ISpecialistsService
    {
        private readonly AppDbContext _context;
        private object dto;
        private object specialists;

        public SpecialistService(AppDbContext context)
        {
            _context = context;
        }

        public object GetSpecialists()
        {
            return specialists;
        }

        public async Task CreateSpecialist(UpdateSpecialistDto specialist)
        {
            var newSpecialist = new Specialist
            { 

                ContactEmail = specialist.ContactEmail,
                Phonenumber = specialist.Phonenumber,
                Description = specialist.Description,
            };


            await _context.Specialists.AddAsync(newSpecialist);
           await  _context.SaveChangesAsync();
            Console.WriteLine($"Specialist with ID {newSpecialist.Id} has been created.");
        }
        public async Task EditSpecialist(UpdateSpecialistDto dto, int id)
        {
            {
                var existingSpecialistTask = _context.Specialists.FirstOrDefaultAsync(x => x.Id == id);
                var existingSpecialist = await existingSpecialistTask;
                if (existingSpecialist != null)
                {
                    // Aktualizacja danych specjalisty
                    existingSpecialist.ContactEmail = dto.ContactEmail;
                    existingSpecialist.Phonenumber = dto.Phonenumber;
                    existingSpecialist.Description = dto.Description;

                     _context.Specialists.Update(existingSpecialist);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    throw new Exception("user not found");   
                }
               

            }
        }

        public async Task DeleteSpecialist(int id)
        {
            var specialistASK = await _context.Specialists.FirstOrDefaultAsync(x => x.Id == id);
            if (specialistASK != null)
            {
                _context.Specialists.Remove(specialistASK);
                await _context.SaveChangesAsync();
            }
            else
            {
                Console.WriteLine($"Specialist with ID {id} not found.");
            }
        }
            public async Task<Specialist> GetSpecialistById(int id)
            {
                var specialist = await _context.Specialists.FirstOrDefaultAsync(s => s.Id == id);

                if (specialist == null)
                {
                    throw new Exception($"Specialist with ID {id} not found.");
                }

                return specialist;
            }

        public Task<List<Specialist>> GetAllSpecialists()
        {
            return _context.Specialists.ToListAsync();
        }
    }
    }    

