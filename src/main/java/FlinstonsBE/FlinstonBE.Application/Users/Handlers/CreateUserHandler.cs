using FlinstonBE.Application.Users.Handlers.Protocols;
using FlinstonBE.Application.Users.Models;
using FlinstonsBE.Domain.Users.Entities;
using FlinstonsBE.Domain.Users.UseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlinstonBE.Application.Users.Handlers
{
    public class CreateUserHandler : ICreateUserHandler
    {
        private readonly ICreateUserUseCase _createUserUseCase;

        public CreateUserHandler(ICreateUserUseCase createUserUseCase)
        {
           _createUserUseCase = createUserUseCase;
        }
        public async Task<UserResponseModel> CreateUserAsync(UserRequestModel userRequestModel)
        {
            User user = new(userRequestModel.Name, userRequestModel.Email);
            await  _createUserUseCase.CreateUserAsync(user);
            UserResponseModel userResponseModel = new()
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
            };
            return userResponseModel;   
        }
    }
}
