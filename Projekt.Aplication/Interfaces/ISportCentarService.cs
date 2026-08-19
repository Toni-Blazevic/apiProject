using Projekt.Aplication.DTO.SportCentar;
using Projekt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Aplication.Interfaces
{
    public interface ISportCentarService
    {
        Task<SportCentar> CreateAsync(CreateSportCentarDto sportCentar);
        Task<SportCentar?> GetByIdAsync(int id);
        Task<IEnumerable<SportCentar>> GetAllAsync();
        Task<bool> DeleteByIdAsync(int id);
        Task<bool> UpdateAsync(int id, CreateSportCentarDto newSportCentar);
    }
}
