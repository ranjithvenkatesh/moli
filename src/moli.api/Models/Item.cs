using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace moli.api.Models
{
  public class Item
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [Required]
    public string Text { get; set; }

    public Audio Audio { get; set; }

    public Image Image { get; set; }
  }
}
