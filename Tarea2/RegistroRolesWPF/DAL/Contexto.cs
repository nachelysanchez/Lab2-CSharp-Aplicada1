using Microsoft.EntityFrameworkCore;
using RegistroRolesWPF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroRolesWPF.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Roles> roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= DATA\RolControl.db");
        }
    }
}
