using FlinstonBE.Application.Favoritos.Handler.Protocols;
using FlinstonBE.Application.Favoritos.Model;
using FlinstonBE.Application.Users.Models;
using FlinstonsBE.Domain.Favoritos.Entites;
using FlinstonsBE.Domain.Favoritos.UseCase;
using FlinstonsBE.Domain.Users.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlinstonBE.Application.Favoritos.Handler
{
    public class CreateFavoritosHandler : ICreateFavoritosHandler
    {
        private readonly ICreateFavoritoUseCase _createFavoritoUseCase;

        public CreateFavoritosHandler(ICreateFavoritoUseCase createFavoritoUseCase)
        {
            _createFavoritoUseCase = createFavoritoUseCase;
        }
        public async Task<FavoritosResposneModel> CreateFavoritosAsync(FavoritosRequestModel favoritosRequestModel)
        {
            Favorito favorito = new(favoritosRequestModel.ItemId, favoritosRequestModel.Modelo, favoritosRequestModel.Preco,
                favoritosRequestModel.Img, favoritosRequestModel.Link, favoritosRequestModel.Desc);
            await _createFavoritoUseCase.CreateFavoritoAsync(favorito);
            FavoritosResposneModel favoritosResposneModel = new()
            {
               Id = favorito.Id,
               ItemId = favorito.ItemId,
               Modelo = favorito.Modelo,    
               Preco = favorito.Preco,
               Img = favorito.Img,      
               Link = favorito.Link,
               Desc = favorito.Desc,
            };
            return favoritosResposneModel;
        }
    }
}
