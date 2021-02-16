using Microsoft.EntityFrameworkCore;

namespace ContSelf.Models
{
    public class FuncionarioContexto : DbContext
    {
        public DbSet<Funcionario> funcionario { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }
    }
}

