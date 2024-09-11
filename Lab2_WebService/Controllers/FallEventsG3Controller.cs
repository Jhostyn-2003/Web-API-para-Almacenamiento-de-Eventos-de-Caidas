using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab2_WebService.Models;

namespace Lab2_WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FallEventsG3Controller : ControllerBase
    {
        private readonly FallEventsDbContext _context;

        public FallEventsG3Controller(FallEventsDbContext context)
        {
            _context = context;
        }

        // GET: api/FallEventsG3
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FallEventsG3>>> GetFallEventsG3s()
        {
            return await _context.FallEventsG3s.ToListAsync();
        }

        // GET: api/FallEventsG3/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FallEventsG3>> GetFallEventsG3(int id)
        {
            var fallEventsG3 = await _context.FallEventsG3s.FindAsync(id);

            if (fallEventsG3 == null)
            {
                return NotFound();
            }

            return fallEventsG3;
        }

        // PUT: api/FallEventsG3/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFallEventsG3(int id, FallEventsG3 fallEventsG3)
        {
            if (id != fallEventsG3.Id)
            {
                return BadRequest();
            }

            _context.Entry(fallEventsG3).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FallEventsG3Exists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/FallEventsG3
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FallEventsG3>> PostFallEventsG3(FallEventsG3 fallEventsG3)
        {
            _context.FallEventsG3s.Add(fallEventsG3);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFallEventsG3", new { id = fallEventsG3.Id }, fallEventsG3);
        }

        // DELETE: api/FallEventsG3/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFallEventsG3(int id)
        {
            var fallEventsG3 = await _context.FallEventsG3s.FindAsync(id);
            if (fallEventsG3 == null)
            {
                return NotFound();
            }

            _context.FallEventsG3s.Remove(fallEventsG3);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FallEventsG3Exists(int id)
        {
            return _context.FallEventsG3s.Any(e => e.Id == id);
        }
    }
}
