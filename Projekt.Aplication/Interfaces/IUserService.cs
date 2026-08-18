using Projekt.Aplication.DTO.User;
using Projekt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Aplication.Interfaces
{
    public interface IUserService
    {
        Task<User> CreateUserAsync(CreateUserDto user);
        Task<bool> UpdateUserAsync(int id, CreateUserDto newUser);
        Task<IEnumerable<UserDto>> GetAllUsersAsync();
        Task<UserDto?> GetUserByIdAsync(int id);
        Task<bool> DeleteUserAsync(int id);
       
    }
}
