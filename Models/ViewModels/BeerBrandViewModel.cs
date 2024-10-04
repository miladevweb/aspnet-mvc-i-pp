using System.ComponentModel.DataAnnotations;

namespace Mvc.Tutorial.Models;
public class BeerBrandViewModel // Validations
{
    [Required]
    [Display(Name = "Nombre")]
    public string Name { get; set; }

    [Required]
    [Display(Name = "Marca")]
    public string Brand { get; set; }
}
