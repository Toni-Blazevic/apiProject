using Projekt.Aplication.DTO.SportCentar;
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
    public class SportCentarService : ISportCentarService
    {
        private readonly ISportCentarRepository _sportCentarRepository;

        public SportCentarService(ISportCentarRepository userRepository)
        {
            _sportCentarRepository = userRepository;
        }

        public async Task<SportCentar> CreateAsync(CreateSportCentarDto sportCentar)
        {
            var sportCentarEntity = await _sportCentarRepository.AddAsync(sportCentar.ToEntity());
            await _sportCentarRepository.SaveChangesAsync();
            return sportCentarEntity;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            if(!await _sportCentarRepository.ExistsAsync(id))
            {
                return false;
            }

            await _sportCentarRepository.DeleteAsync(await _sportCentarRepository.GetByIdAsync(id));
            await _sportCentarRepository.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<SportCentar>> GetAllAsync()
        {
            return await _sportCentarRepository.GetAllAsync();
        }

        public async Task<SportCentar?> GetByIdAsync(int id)
        {
            return await _sportCentarRepository.GetByIdAsync(id);
        }

        public async Task<SportCentarWithTerrainsDto?> GetSportCentarWithTerrains(int id)
        {
            var sportCentar = await _sportCentarRepository.GetSportCentarWithTerrainsAsync(id);
            if(sportCentar == null)
            {
                return null;
            }

            return new SportCentarWithTerrainsDto
                (
                    sportCentar.Name,
                    sportCentar.Addres,
                    sportCentar.City,
                    sportCentar.Description,
                    sportCentar.Terrains.
                        Select(t => t.ToTerrainNoSportCentar()).
                        ToList()
                );
        }

        public async Task<bool> UpdateAsync(int id, CreateSportCentarDto newSportCentar)
        {
            if(!await _sportCentarRepository.ExistsAsync(id))
            {
                return false;
            }

            var newSportCenterEntity = newSportCentar.ToEntity();
            newSportCenterEntity.Id = id;

            await _sportCentarRepository.UpdateAsync(newSportCenterEntity);
            await _sportCentarRepository.SaveChangesAsync();

            return true;
        }
    }
}
