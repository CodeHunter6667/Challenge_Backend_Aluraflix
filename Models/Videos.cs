using System.ComponentModel.DataAnnotations;

namespace Aluraflix.Models
{
    public class Videos
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string? Nome { get; set; }
        [Required]
        public string? Descricao { get; set; }
        [Required]
        public string? Url { get; set; }
    }
}
