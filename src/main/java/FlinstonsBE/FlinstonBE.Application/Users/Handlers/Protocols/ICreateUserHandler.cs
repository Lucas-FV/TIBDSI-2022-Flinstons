using FlinstonBE.Application.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlinstonBE.Application.Users.Handlers.Protocols
{
    public interface ICreateUserHandler
    {
        Task<UserResponseModel> CreateUserAsync(UserRequestModel userRequestModel);

    }
}
