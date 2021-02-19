using ContSelf.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContSelf.Entidade
{
    public class Agenda
    {
        public int Id { get; set; }
        public List<Cliente> Clientes { get; set; }
        public DateTime Agendamento { get; set; }
        public List<Servico> Servicos { get; set; }
        [Column(TypeName = "decimal (18,4)")]
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99)]
        public Pagamento Pagamento { get; set; }
        [Column(TypeName = "decimal (18,4)")]
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99)]
        public decimal Desconto { get; set; }
        public List<Funcionario> Profissional { get; set; }


    }
}
