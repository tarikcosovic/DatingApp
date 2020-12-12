using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DummyController : ControllerBase
    {
        private readonly DataContext _context;
        public DummyController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetDummies(){

            var result = await _context.Dummies.AsNoTracking().ToListAsync();
            
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDummy(int id){

            var result = await _context.Dummies.FirstOrDefaultAsync(x => x.DummyId == id);

            return Ok(result);
        }
    }
}