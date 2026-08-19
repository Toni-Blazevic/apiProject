using Projekt.Aplication.DTO.Terrain;
using Projekt.Aplication.Interfaces;
using Projekt.Aplication.Mapping;
using Projekt.Domain.Entities;
using Projekt.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Aplication.Services
{
    public class TerrainService : ITerrainService
    {
        private readonly ITerrainRepository _terrainRepository;

        public TerrainService(ITerrainRepository terrainRepository)
        {
            _terrainRepository = terrainRepository;
        }

        public async Task<Terrain> CreateAsync(CreateTerrainDto terrain)
        {
            var newTerrain = await _terrainRepository.AddAsync(terrain.ToEntity());
            await _terrainRepository.SaveChangesAsync();

            return newTerrain;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            if(! await _terrainRepository.ExistsAsync(id))
            {
                return false;
            }

            await _terrainRepository.DeleteAsync(await _terrainRepository.GetByIdAsync(id));
            await _terrainRepository.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<Terrain>> GetAllAsync()
        {
            return await _terrainRepository.GetAllAsync();
        }

        public async Task<Terrain?> GetByIdAsync(int id)
        {
            return await _terrainRepository.GetByIdAsync(id);
        }

        public async Task<bool> UpdateByIdAsync(int id, CreateTerrainDto newTerrain)
        {
            if (!await _terrainRepository.ExistsAsync(id))
            {
                return false;
            }

            Terrain terrainEntity = await _terrainRepository.GetByIdAsync(id);

           terrainEntity.Id = id;

            await _terrainRepository.UpdateAsync(terrainEntity);
            await _terrainRepository.SaveChangesAsync();

            return true;
        }
    }
}
