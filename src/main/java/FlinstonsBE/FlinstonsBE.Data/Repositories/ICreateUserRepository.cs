using FlinstonsBE.Data.Users.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlinstonsBE.Data.Repositories
{
    public interface ICreateUserRepository
    {
        Task CreateUserAsync(UserDataTransfer  userDataTransfer);

    }
}
