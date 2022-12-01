using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mestreflix.Models
{
    public class Review
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Text { get; set; }

        public int MovieId { get; set; }

        public Movie? Movie { get; set; }
    }
}
