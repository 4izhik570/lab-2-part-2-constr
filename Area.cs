using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab2_Part3.Models;

[Table("areas")]
public class Area
{
    [Key]
    public int Id { get; set; }
    // Навигационное свойство: список улиц на этом участке
    public virtual ICollection<Street> Streets { get; set; } = new List<Street>();
}
