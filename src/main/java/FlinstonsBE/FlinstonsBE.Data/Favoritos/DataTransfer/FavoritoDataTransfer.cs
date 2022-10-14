using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlinstonsBE.Data.Favoritos.DataTransfer
{
    public class FavoritoDataTransfer
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string modelo { get; set; } = string.Empty;
        public int preco { get; set; } 
        public string img { get; set; } = string.Empty;
        public string link { get; set; } = string.Empty;
        public string desc { get; set; } = string.Empty;

    }
}
