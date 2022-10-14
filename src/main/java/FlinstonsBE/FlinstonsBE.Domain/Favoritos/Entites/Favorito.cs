using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlinstonsBE.Domain.Favoritos.Entites
{
    public class Favorito
    {
        public Favorito(int itemId, string modelo, int preco, string img, string link, string desc)
        {
            ItemId = itemId;
            Modelo = modelo;
            Preco = preco;
            Img = img;
            Link = link;
            Desc = desc;
        }
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Modelo { get; set; } = string.Empty;
        public int Preco { get; set; }
        public string Img { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        public string Desc { get; set; } = string.Empty;

        public void SetId(int id)
        {
            this.Id = id;
        }
    }
}
