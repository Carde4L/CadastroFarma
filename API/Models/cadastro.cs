

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Cadastro
    {
        [Key]
        [Required]
        [Column("RG")]
        public long Id
        { get; set; }
        [Required]
        [Column("Nome Completo")]
        public string Nome
        { get; set; }
        [Required]
        public string email
        { get; set; }
        [Required]
        public string CPF
        { get; set; }
        [Required]
        [Column("Data do Nascimento")]
        public string dNascimento
        { get; set; }
        [Required]
        [Column("Numero de Contato")]
        public string Ncontato
        { get; set; }
        [Required]
        public string Endereco
        { get; set; }
        [Required]
        public string Convenios
        { get; set; }


    }
}
