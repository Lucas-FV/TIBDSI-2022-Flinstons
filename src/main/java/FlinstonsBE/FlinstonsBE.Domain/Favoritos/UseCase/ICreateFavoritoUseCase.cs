using FlinstonsBE.Domain.Favoritos.Entites;
using FlinstonsBE.Domain.Users.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlinstonsBE.Domain.Favoritos.UseCase
{
    public interface ICreateFavoritoUseCase
    {
        Task CreateFavoritoAsync(Favorito favorito);
    }
}
