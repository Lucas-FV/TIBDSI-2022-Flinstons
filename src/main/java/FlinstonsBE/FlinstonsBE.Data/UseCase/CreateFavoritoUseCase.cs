using FlinstonsBE.Data.Favoritos.DataTransfer;
using FlinstonsBE.Data.Repositories;
using FlinstonsBE.Data.Users.DataTransfer;
using FlinstonsBE.Domain.Favoritos.Entites;
using FlinstonsBE.Domain.Favoritos.UseCase;
using FlinstonsBE.Domain.Users.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlinstonsBE.Data.UseCase
{
    public class CreateFavoritoUseCase : ICreateFavoritoUseCase
    {
        private readonly ICreateFavoritosRepository _createFavoritosRepository;

        public CreateFavoritoUseCase(ICreateFavoritosRepository createFavoritosRepository)
        {
            _createFavoritosRepository = createFavoritosRepository;
        }
        public async Task CreateFavoritoAsync(Favorito favorito)
        {

            FavoritoDataTransfer favoritoDataTransfer = new()
            {
                ItemId = favorito.ItemId,
                modelo = favorito.Modelo,
                preco = favorito.Preco,
                desc = favorito.Desc,   
                link = favorito.Link,
                img = favorito.Img
            };
            await _createFavoritosRepository.CreateFavoritoAsync(favoritoDataTransfer);
            favorito.SetId(favorito.Id);
        }
    }
}
