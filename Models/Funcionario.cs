using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public string AtividadeExibicao
        {
            get
            {
                if (Atividade.Length > 150)
                    return Atividade.Substring(0, 150) + "...";

                return Atividade;
            }
        }
    }
}
