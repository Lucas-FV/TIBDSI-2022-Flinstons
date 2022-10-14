using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlinstonBE.Application.Users.Models
{
    public class UserRequestModel
    {
        [Required(ErrorMessage = "O Campo nome é obrigatorio")]

        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "O Campo email é obrigatorio")]

        public string Email { get; set; } = string.Empty;

    }

    public class UserResponseModel
    {
        [Required(ErrorMessage = "O campo Id deve ter um retorno")]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome deve ter um retorno")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "O campo Email deve ter um retorno")]
        public string Email { get; set; } = string.Empty;


    }
}
