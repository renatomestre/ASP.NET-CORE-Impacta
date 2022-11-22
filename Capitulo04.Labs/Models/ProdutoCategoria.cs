using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capitulo04.Labs.Models
{
    public class ProdutoCategoria
    {
        [Key]
        [Column(Order = 1)]
        public int ProdutoId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int CategoriaId { get; set; }
    }
}