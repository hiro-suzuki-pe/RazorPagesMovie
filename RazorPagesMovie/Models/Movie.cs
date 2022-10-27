using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;

        [Display(Name = "リリース日")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "ジャンル")]
        public string Genre { get; set; } = string.Empty;

        [Column(TypeName ="decimal(18,4)")]
        public decimal Price { get; set; }
    }
}
