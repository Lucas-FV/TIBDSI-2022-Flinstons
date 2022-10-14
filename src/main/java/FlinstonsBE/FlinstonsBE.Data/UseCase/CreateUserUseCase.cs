using FlinstonsBE.Data.Repositories;
using FlinstonsBE.Data.Users.DataTransfer;
using FlinstonsBE.Domain.Users.Entities;
using FlinstonsBE.Domain.Users.UseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlinstonsBE.Data.UseCase
{
    public class CreateUserUseCase : ICreateUserUseCase
    {
        private readonly ICreateUserRepository _createUserRepository;

        public CreateUserUseCase(ICreateUserRepository createUserRepository)
        {
           _createUserRepository = createUserRepository;
        }
        public async Task CreateUserAsync(User user)
        {
            UserDataTransfer userDataTransfer = new()
            {
                Name = user.Name,
                Email = user.Email
            };
            await _createUserRepository.CreateUserAsync(userDataTransfer);
            user.SetId(user.Id);

        }
    }
}
