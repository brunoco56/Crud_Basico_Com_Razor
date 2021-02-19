using ContSelf.Entidade;
using Microsoft.EntityFrameworkCore;

namespace ContSelf.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<Cliente> Cliente{ get; set; }
        public DbSet<Custo> Custo { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Pagamento> Pagamento { get; set; }
        public DbSet<Servico> Servico { get; set; }
       
        //Construtor que chama o Banco de Dados
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
       
    }
}

