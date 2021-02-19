using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContSelf.Entidade
{
    public class Servico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Column(TypeName = "decimal (18,4)")]
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99)]
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
       
    }
}
