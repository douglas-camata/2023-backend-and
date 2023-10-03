using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_MVC.Models
{
    public class Jogo
    {
        [Key]
        public int JogoId { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }
    }
}