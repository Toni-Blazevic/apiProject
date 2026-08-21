using Projekt.Aplication.DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Domain.Entities;
using Projekt.Aplication.DTO.SportCentar;
using Projekt.Aplication.DTO.Terrain;
using Projekt.Aplication.DTO.Reservation;
using Projekt.Aplication.DTO.Review;

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

        public static TerrainWithReviews ToTerrainWithReviews(this Terrain terrain)
        {
            return new TerrainWithReviews
                (
                    terrain.Name,
                    terrain.SportTypeId,
                    terrain.SportCentarId,
                    terrain.PriceByHour,
                    terrain.IsInDoor,
                    terrain.Reviews.
                        Select<Review, RewievWithNoTerrain>(r => r.ToReviewWithNoTerrain()).
                        ToList()
                );
        }
        #endregion
        #region Reservation
        public static Reservation ToEntity(this CreateReservationDto dto)
        {
            return new Reservation
            {
                TerrainId = dto.TerrainId,
                StartTime = dto.StartTime,
                EndTime = dto.EndTime,
                TotalPrice = dto.TotalPrice
            };
        }
        #endregion
        #region Rewiev
        public static RewievWithNoTerrain ToReviewWithNoTerrain(this Review review)
        {
            return new RewievWithNoTerrain
                (
                    review.UserId,
                    review.Rating,
                    review.Comment,
                    review.CreatedAt
                );
        }
        public static Review ToEntity(this CreateReviewDto dto)
        {
            return new Review
            {
                UserId = dto.UserId,
                TerrainId = dto.TerrainId,
                Rating = dto.Rating,
                Comment = dto.Comment,
                CreatedAt = dto.CreatedAt
            };
        }
        #endregion
    }
}
