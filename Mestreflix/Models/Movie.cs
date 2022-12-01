using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mestreflix.Models
{
    public class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [DisplayName("Título")]
        public string Title { get; set; }

        [Required]
        [DisplayName("Gênero")]
        public string Genre { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Lançamento")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [DisplayName("Alugue por")]
        public decimal Price { get; set; }

        [Required]
        [DisplayName("Capa (formato base64)")]
        public string Cover { get; set; }

        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}
