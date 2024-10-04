using Mvc.Tutorial.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mvc.Tutorial.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ApiControllerBeer: ControllerBase
{
    private readonly PubContext _context;

    public ApiControllerBeer(PubContext context)
    {
        _context = context;
    }

    public async Task<List<Beer>> Get()
    => await _context.Beers.ToListAsync();
}
