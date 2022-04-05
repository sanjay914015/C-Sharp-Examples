using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_with_API.Data;
using MVC_with_API.Models;

namespace MVC_with_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortsController : ControllerBase
    {
        private readonly PortsContext _context;

        public PortsController(PortsContext context)
        {
            _context = context;
        }

        // GET: api/Ports
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ports>>> GetPort()
        {
            return await _context.Port.ToListAsync();
        }

        // GET: api/Ports/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ports>> GetPorts(int id)
        {
            var ports = await _context.Port.FindAsync(id);

            if (ports == null)
            {
                return NotFound();
            }

            return ports;
        }

        // PUT: api/Ports/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPorts(int id, Ports ports)
        {
            if (id != ports.Id)
            {
                return BadRequest();
            }

            _context.Entry(ports).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PortsExists(id))
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

        // POST: api/Ports
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ports>> PostPorts(Ports ports)
        {
            Boolean asw = Convert.ToBoolean(await _context.Port.FindAsync(ports.Id));
            if (PortsExists(ports.Id))
            {
                return NotFound();
            }
            _context.Port.Add(ports);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPorts", new { id = ports.Id }, ports);
        }

        // DELETE: api/Ports/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ports>> DeletePorts(int id)
        {
            var ports = await _context.Port.FindAsync(id);
            if (ports == null)
            {
                return NotFound();
            }

            _context.Port.Remove(ports);
            await _context.SaveChangesAsync();

            return ports;
        }

        private bool PortsExists(int id)
        {
            return _context.Port.Any(e => e.Id == id);
        }
    }
}
