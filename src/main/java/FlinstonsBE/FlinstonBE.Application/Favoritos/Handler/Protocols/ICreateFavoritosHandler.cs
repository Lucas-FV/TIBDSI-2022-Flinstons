using FlinstonBE.Application.Favoritos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlinstonBE.Application.Favoritos.Handler.Protocols
{
    public interface ICreateFavoritosHandler
    {
        Task<FavoritosResposneModel> CreateFavoritosAsync(FavoritosRequestModel favoritosRequestModel);

    }
}
