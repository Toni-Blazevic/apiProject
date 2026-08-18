using Microsoft.EntityFrameworkCore;
using Projekt.Aplication.DTO.User;
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
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> CreateUserAsync(CreateUserDto user)
        {
            var userEntity = await _userRepository.AddAsync(user.ToEntity());
            await _userRepository.SaveChangesAsync();
            return userEntity;
            
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null)
            {
                return false;
            }
            await _userRepository.DeleteAsync(user);
            await _userRepository.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return users.Select(u => u.ToDto());
        }

        public async Task<UserDto?> GetUserByIdAsync(int id)
        {
            User? user = await _userRepository.GetByIdAsync(id);
            return user?.ToDto();
        }

        public async Task<bool> UpdateUserAsync(int id, CreateUserDto newUser)
        {
            if (!await _userRepository.ExistsAsync(id))
            {
                return false;
            }
            
            User user = newUser.ToEntity();
            user.Id = id;

            await _userRepository.UpdateAsync(user);
            await _userRepository.SaveChangesAsync();

            return true;
        }
    }
}
