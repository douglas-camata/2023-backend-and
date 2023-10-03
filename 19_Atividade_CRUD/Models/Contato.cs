using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_MVC.Models
{
    [Table("Contatos")]
    public class Contato
    {
        [Key]
        public int ContatoId { get; set; }

        [Required(ErrorMessage="Digite o nome do contato")]
        [Display(Name="Nome do contato")]
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
    }
}