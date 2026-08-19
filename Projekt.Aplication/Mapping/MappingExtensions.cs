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
    }
}
