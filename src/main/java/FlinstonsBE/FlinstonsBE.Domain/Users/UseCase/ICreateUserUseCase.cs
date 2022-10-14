using FlinstonsBE.Domain.Users.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlinstonsBE.Domain.Users.UseCase
{
    public interface ICreateUserUseCase
    {
        Task CreateUserAsync(User user);
    }
}
