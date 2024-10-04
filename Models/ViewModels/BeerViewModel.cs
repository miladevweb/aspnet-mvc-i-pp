using System.ComponentModel.DataAnnotations;

namespace Mvc.Tutorial.Models;
public class BeerViewModel // Validations
{
    [Required]
    [Display(Name = "Nombre")]
    public string Name { get; set; }

    [Required]
    [Display(Name = "Marca")]
    public int BrandId { get; set; }
}
