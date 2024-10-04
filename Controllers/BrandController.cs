using Mvc.Tutorial.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mvc.Tutorial.Controllers;

// Each controller must have a Index method
public class BrandController: Controller
{
    // Fields
    private readonly PubContext _context;

    // Constructor
    public BrandController(PubContext context) => _context = context;

    public async Task<IActionResult> Index() 
    => View(await _context.Brands.ToListAsync());
    public IActionResult SecondaryRoute()
    {
        return View();
    }
}
