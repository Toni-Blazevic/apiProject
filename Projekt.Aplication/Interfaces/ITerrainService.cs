using Projekt.Aplication.DTO.Terrain;
using Projekt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Aplication.Interfaces
{
    public interface ITerrainService
    {
        public Task<Terrain> CreateAsync(CreateTerrainDto terrain);
        public Task<Terrain?> GetByIdAsync(int id);
        public Task<IEnumerable<Terrain>> GetAllAsync();
        public Task<bool> DeleteByIdAsync(int id);
        public Task<bool> UpdateByIdAsync(int id, CreateTerrainDto newTerrain);

    }
}
