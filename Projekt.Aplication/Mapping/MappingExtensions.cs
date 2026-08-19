using Projekt.Aplication.DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Domain.Entities;
using Projekt.Aplication.DTO.SportCentar;
using Projekt.Aplication.DTO.Terrain;

namespace Projekt.Aplication.Mapping
{
    public static class MappingExtensions
    {
        #region User
        public static User ToEntity(this CreateUserDto user)
        {
            return new User
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PasswordHash = user.PasswordHash,
                PhoneNumber = user.PhoneNumber
            };
        }
        public static UserDto ToDto(this User user)
        {
            return new UserDto
                (
                    user.Id,
                    user.FirstName,
                    user.LastName,
                    user.Email,
                    user.PhoneNumber
                );
        }
        #endregion
        #region SportCentar
        public static SportCentar ToEntity(this CreateSportCentarDto sportCentar)
        {
            return new SportCentar
            {
                Name = sportCentar.Name,
                Addres = sportCentar.Adress,
                City = sportCentar.City,
                Description = sportCentar.Description
            };
        }
        #endregion
        #region Terrain
        public static Terrain ToEntity(this CreateTerrainDto terrain)
        {
            return new Terrain
            {
                Name = terrain.Name,
                SportCentarId = terrain.SportCentarId,
                SportTypeId = terrain.SportTypeId,
                PriceByHour = terrain.PriceByHour,
                IsInDoor = terrain.IsInDoor
            };
        }

        public static TerrainWithNoSportCentar ToTerrainNoSportCentar(this Terrain terrain)
        {
            return new TerrainWithNoSportCentar
            (
                terrain.Name,
                terrain.SportTypeId,
                terrain.PriceByHour,
                terrain.IsInDoor
            );
        }
        #endregion
    }
}
