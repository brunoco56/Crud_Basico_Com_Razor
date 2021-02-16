using Microsoft.EntityFrameworkCore;

namespace ContSelf.Models
{
    public class FuncionarioContexto : DbContext
    {
        public DbSet<Funcionario> funcionario { get; set; }
        //Construtor que chama o Banco de Dados
        public FuncionarioContexto(DbContextOptions<FuncionarioContexto> options) : base(options)
        {

        }
       
    }
}

