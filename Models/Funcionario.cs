using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContSelf.Models
{
    public class Funcionario
    {
        [Key]
        public int CodFuncionario { get; set; }

        [Required]
        [StringLength(400)]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Required]
        [Range(1, 100000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Salario { get; set; }

        [Required]
        public string Atividade { get; set; }
    }
}
