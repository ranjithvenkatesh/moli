using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace moli.api.Models
{
  public class User
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Name { get; set; }

    public ICollection<Lesson> Lessons { get; set; }

    public ICollection<Test> Tests { get; set; }
  }
}
