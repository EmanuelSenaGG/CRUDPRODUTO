using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeiroCRUD.Models
{
    [Table("Produtos")]
    public class ProdutoModel
    {
        [Column("Id")]
        [Display(Name ="Código")]
        public int Id { get; set; }
        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Column("Quantidade")]
        [Display(Name = "Estoque")]
        public int Estoque { get; set; }
        [Column("Valor")]
        [Display(Name = "Preço")]
        public int Preco {get; set; }
    }
}
