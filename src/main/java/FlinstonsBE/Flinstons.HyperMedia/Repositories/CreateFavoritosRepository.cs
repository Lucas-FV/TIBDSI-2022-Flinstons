using FlinstonsBE.Data.Favoritos.DataTransfer;
using FlinstonsBE.Data.Repositories;
using FlinstonsBE.Data.Users.DataTransfer;
using FlinstonsBE.Infrastructure.Context;

namespace Flinstons.HyperMedia.Repositories
{
    public class CreateFavoritosRepository : ICreateFavoritosRepository
    {
        private readonly BackEndDataContext _backEndDataContext;

        public CreateFavoritosRepository(BackEndDataContext backEndDataContext)
        {
            _backEndDataContext = backEndDataContext;
        }
        public async Task CreateFavoritoAsync(FavoritoDataTransfer favoritoDataTransfer)
        {
            await _backEndDataContext.AddAsync(favoritoDataTransfer);
            await _backEndDataContext.SaveChangesAsync();
        }
    }
}

       

