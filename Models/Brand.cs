﻿namespace Mvc.Tutorial.Models;
public partial class Brand
{
    public int BrandId { get; set; }
    public string Name { get; set; } = null!;
    public virtual ICollection<Beer> Beers { get; set; } = new List<Beer>();
}
