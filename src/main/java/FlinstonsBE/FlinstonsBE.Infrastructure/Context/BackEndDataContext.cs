using FlinstonsBE.Data.Favoritos.DataTransfer;
using FlinstonsBE.Data.Users.DataTransfer;
using FlinstonsBE.Infrastructure.Context.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlinstonsBE.Infrastructure.Context
{
    public class BackEndDataContext : DbContext
    {
        public BackEndDataContext(DbContextOptions<BackEndDataContext> dbContextOptions)
            : base(dbContextOptions)
        {
        }
        public DbSet<UserDataTransfer> Users { get; set; }
        public DbSet<FavoritoDataTransfer> Favoritos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration()); 
            modelBuilder.ApplyConfiguration(new FavoritosConfiguration());

        }

    }
}
