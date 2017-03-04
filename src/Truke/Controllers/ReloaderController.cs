using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Truke.Data;
using Truke.Models;

namespace Truke.Controllers
{
    [Produces("application/json")]
    [Route("{id}")]
    public class ReloaderController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReloaderController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetLink([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Link link = await _context.Link.SingleOrDefaultAsync(m => m.Id == id);

            if (link == null)
            {
                return NotFound();
            }

            return Redirect(link.url);
        }
    }
}