using Lab2_Part3.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab2_Part3.Models;

[Table("streets")]
public class Street
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(60)]
    public string Name { get; set; } = null!;

    // Новое свойство: почтовый индекс (char 6)
    [MaxLength(6)]
    [Column(TypeName = "char(6)")]
    public string? PostalIndex { get; set; }

    public int AreaId { get; set; }

    [ForeignKey("AreaId")]
    public virtual Area Area { get; set; } = null!;
}

