using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlinstonBE.Application.Favoritos.Model
{
    public class FavoritosRequestModel
    {
        public int ItemId { get; set; }
        public string Modelo { get; set; } = string.Empty;
        public int Preco { get; set; }
        public string Img { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        public string Desc { get; set; } = string.Empty;
    }

    public class FavoritosResposneModel
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Modelo { get; set; } = string.Empty;
        public int Preco { get; set; }
        public string Img { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        public string Desc { get; set; } = string.Empty;
    }
}
