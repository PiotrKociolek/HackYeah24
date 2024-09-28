using FitLife.Data;
using FitLife.Dto;
using FitLife.entities;

namespace FitLife.Entities.Services
{
    public interface ISpecialistsService
    {
        Task CreateSpecialist(UpdateSpecialistDto specialist);
        Task EditSpecialist(UpdateSpecialistDto dto, int id);
        Task DeleteSpecialist(int id);
        Task<Specialist> GetSpecialistById(int id);
        Task<List<Specialist>> GetAllSpecialists(); 
    }
}



