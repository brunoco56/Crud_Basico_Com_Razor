using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContSelf.Models
{
    public class FuncionarioContexto : DbContext
    {
        public DbSet<Funcionario> funcionario { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = DESKTOP-OF0L99J\SQLEXPRESS; Initial Catalog = ContSelf; Integrated Security = True");
        }
    }
}

