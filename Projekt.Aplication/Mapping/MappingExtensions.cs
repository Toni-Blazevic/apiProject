using Projekt.Aplication.DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Domain.Entities;

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
    }
}
