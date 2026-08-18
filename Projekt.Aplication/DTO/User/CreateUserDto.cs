using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Aplication.DTO.User
{
    public record CreateUserDto(string FirstName, string LastName, string PasswordHash, string Email, string PhoneNumber);
}
