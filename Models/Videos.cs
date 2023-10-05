using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aluraflix.Models;

[Table("tb_videos")]
public class Videos
{
    [Key]
    public long Id { get; set; }
    [Required]
    [StringLength(50, MinimumLength = 5 , ErrorMessage = "O nome do video deve ter entre 5 e 50 caracteres")]
    public string? Nome { get; set; }
    [Required]
    [StringLength(200, MinimumLength = 15, ErrorMessage = "A descricao do video deve ter entre 15 e 200 caracteres")]
    public string? Descricao { get; set; }
    [Required]
    public string? Url { get; set; }
}
