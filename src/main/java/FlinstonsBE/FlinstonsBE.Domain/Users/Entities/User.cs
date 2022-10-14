using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlinstonsBE.Domain.Users.Entities
{
    public class User
    {
        public User(string name, string email)
        {
            Name = name;            
            Email = email;

        }
        public int Id { get; private set; }
        public string Name { get; } = string.Empty;
        public string Email { get; } = string.Empty;

        public void SetId(int id)
        {
            this.Id = id;
        }
    }
}
