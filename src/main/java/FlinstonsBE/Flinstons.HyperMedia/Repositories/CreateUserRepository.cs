using FlinstonsBE.Data.Repositories;
using FlinstonsBE.Data.Users.DataTransfer;
using FlinstonsBE.Infrastructure.Context;

namespace Flinstons.HyperMedia.Repositories
{
    public class CreateUserRepository : ICreateUserRepository
    {
        private readonly BackEndDataContext _backEndDataContext;

        public CreateUserRepository(BackEndDataContext backEndDataContext )
        {
            _backEndDataContext = backEndDataContext;
        }
        public async Task CreateUserAsync(UserDataTransfer userDataTransfer)
        {
            await _backEndDataContext.AddAsync(userDataTransfer);
            await _backEndDataContext.SaveChangesAsync();
        }
    }
}
