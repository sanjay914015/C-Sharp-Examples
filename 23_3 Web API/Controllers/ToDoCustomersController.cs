using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _23_3_Web_API.Models;

namespace _23_3_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoCustomersController : ControllerBase
    {
        private readonly ToDoContextCustomer _context;

        public ToDoCustomersController(ToDoContextCustomer context)
        {
            _context = context;
        }

        // GET: api/ToDoCustomers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToDoCustomer>>> GetTodoCustomers()
        {
            return await _context.TodoCustomers.ToListAsync();
        }

        // GET: api/ToDoCustomers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ToDoCustomer>> GetToDoCustomer(long id)
        {
            var toDoCustomer = await _context.TodoCustomers.FindAsync(id);

            if (toDoCustomer == null)
            {
                return NotFound();
            }

            return toDoCustomer;
        }

        // PUT: api/ToDoCustomers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutToDoCustomer(long id, ToDoCustomer toDoCustomer)
        {
            if (id != toDoCustomer.Id)
            {
                return BadRequest();
            }

            _context.Entry(toDoCustomer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToDoCustomerExists(id))
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

        // POST: api/ToDoCustomers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ToDoCustomer>> PostToDoCustomer(ToDoCustomer toDoCustomer)
        {
            _context.TodoCustomers.Add(toDoCustomer);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetToDoCustomer", new { id = toDoCustomer.Id }, toDoCustomer);
            return CreatedAtAction(nameof(GetToDoCustomer), new { id = toDoCustomer.Id }, toDoCustomer);

        }

        // DELETE: api/ToDoCustomers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ToDoCustomer>> DeleteToDoCustomer(long id)
        {
            var toDoCustomer = await _context.TodoCustomers.FindAsync(id);
            if (toDoCustomer == null)
            {
                return NotFound();
            }

            _context.TodoCustomers.Remove(toDoCustomer);
            await _context.SaveChangesAsync();

            return toDoCustomer;
        }

        private bool ToDoCustomerExists(long id)
        {
            return _context.TodoCustomers.Any(e => e.Id == id);
        }
    }
}
