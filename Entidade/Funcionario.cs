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
        [StringLength(200)]
        [ConcurrencyCheck]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        [Column(TypeName = "decimal (18,4)")]
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99)]
        public virtual Decimal ? Salario { get; set; }

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
