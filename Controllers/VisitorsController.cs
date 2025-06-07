using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using VisitorAPI.Data;
using VisitorAPI.Models;


namespace VisitorAPI.Controllers
{
    [ApiController]
    [Route("blacklist.html/api/[controller]")]
    public class VisitorsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public VisitorsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Visitor>>> GetVisitors()
        {
            return await _context.Visitors.ToListAsync();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBlacklistStatus(int id, [FromBody] bool isBlacklisted)
        {
            var visitor = await _context.Visitors.FindAsync(id);
            if (visitor == null) return NotFound();

            visitor.IsBlacklisted = isBlacklisted;
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
