using Microsoft.EntityFrameworkCore;

namespace ContSelf.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Funcionario> funcionario { get; set; }
        //Construtor que chama o Banco de Dados
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
       
    }
}

