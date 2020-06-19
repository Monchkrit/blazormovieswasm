using System.ComponentModel.DataAnnotations;

namespace blazormovieswasm.Shared.Entities
{
  public class Genre
  {  
    public int Id { get; set; }
    [Required (ErrorMessage="This field is required")]
    public string Name { get; set; }
  }
}