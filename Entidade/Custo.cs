using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContSelf.Entidade
{
    public class Custo
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        [Column(TypeName = "decimal (18,4)")]
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99)]
        public decimal valor { get; set; }
    }
}
