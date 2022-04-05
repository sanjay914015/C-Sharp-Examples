using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Read_EDI_Data.Data;
using Read_EDI_Data.Models;
using System.IO;

namespace Read_EDI_Data.Controllers
{
    public class Ports1Controller : Controller
    {
        private readonly Read_EDI_DataContext _context;

        public Ports1Controller(Read_EDI_DataContext context)
        {
            _context = context;
        }

        // GET: Ports1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ports.ToListAsync());
        }

        // GET: Ports1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ports = await _context.Ports
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ports == null)
            {
                return NotFound();
            }

            return View(ports);
        }

        // GET: Ports1/Create
        public async Task<IActionResult> Create([Bind("Id,ISA,GS,ST,Big,N1,N3,N4")] Ports ports)
        {
            String path = @"C:\Users\Lenovo\Desktop\test.txt";

            System.IO.StreamReader reader;
            reader = new System.IO.StreamReader(path);
            string Data = reader.ReadToEnd();
            reader.Close();

            string[] values = Data.Split('~');
            List<string> ISA = new List<string>();
            List<string> GS = new List<string>();
            List<string> ST = new List<string>();
            List<string> BIG = new List<string>();
            List<string> N1 = new List<string>();
            List<string> N3 = new List<string>();
            List<string> N4 = new List<string>();



            for (int i = 0; i < values.Length; i++)
            {
                if (values[i].Contains("ISA"))
                {
                    ISA.Add(Convert.ToString(values[i]));
                }
                else if (values[i].Contains("GS"))
                {
                    GS.Add(Convert.ToString(values[i]));
                }
                else if (values[i].Contains("ST"))
                {
                    ST.Add(Convert.ToString(values[i]));
                }
                else if (values[i].Contains("BIG"))
                {
                    BIG.Add(Convert.ToString(values[i]));
                }
                else if (values[i].Contains("N1"))
                {
                    N1.Add(Convert.ToString(values[i]));
                }
                else if (values[i].Contains("N3"))
                {
                    N3.Add(Convert.ToString(values[i]));
                }
                else if (values[i].Contains("N4"))
                {
                    N4.Add(Convert.ToString(values[i]));

                }
            }
            ports.ISA = string.Join(Environment.NewLine, ISA);
            ports.GS = string.Join(Environment.NewLine, GS);
            ports.ST = string.Join(Environment.NewLine, ST);
            ports.Big = string.Join(Environment.NewLine, BIG);
            ports.N1 = string.Join(Environment.NewLine, N1);
            ports.N3 = string.Join(Environment.NewLine, N3);
            ports.N4 = string.Join(Environment.NewLine, N4);

            if (ModelState.IsValid)
            {
                _context.Add(ports);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ports);
        }

        // POST: Ports1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create1([Bind("Id,ISA,GS,ST,Big,N1,N3,N4")] Ports ports)
        {
            String path = @"C:\Users\Lenovo\Desktop\test.txt";

            System.IO.StreamReader reader;
            reader = new System.IO.StreamReader(path);
            string Data = reader.ReadToEnd();
            reader.Close();

            string[] values = Data.Split('~');
            List<string> ISA = new List<string>();
            List<string> GS = new List<string>();
            List<string> ST = new List<string>();
            List<string> BIG = new List<string>();
            List<string> N1 = new List<string>();
            List<string> N3 = new List<string>();
            List<string> N4 = new List<string>();



            for (int i = 0; i < values.Length; i++)
            {
                if (values[i].Contains("ISA")) 
                {
                    ISA.Add(Convert.ToString(values[i])); 
                }
                else if (values[i].Contains("GS"))
                {
                    GS.Add(Convert.ToString(values[i]));
                }
                else if (values[i].Contains("ST"))
                {
                    ST.Add(Convert.ToString(values[i]));

                }
                else if (values[i].Contains("BIG"))
                {
                    BIG.Add(Convert.ToString(values[i]));

                }
                else if (values[i].Contains("N1"))
                {
                    N1.Add(Convert.ToString(values[i]));

                }
                else if (values[i].Contains("N3"))
                {
                    N3.Add(Convert.ToString(values[i]));
                }
                else if (values[i].Contains("N4"))
                {
                    N4.Add(Convert.ToString(values[i]));

                }
            }
            ports.ISA = string.Join(Environment.NewLine, ISA);
            ports.GS = string.Join(Environment.NewLine, GS);
            ports.ST = string.Join(Environment.NewLine, ST);
            ports.Big = string.Join(Environment.NewLine, BIG);
            ports.N1 = string.Join(Environment.NewLine, N1);
            ports.N3 = string.Join(Environment.NewLine, N3);
            ports.N4 = string.Join(Environment.NewLine, N4);

            if (ModelState.IsValid)
            {
                _context.Add(ports);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ports);
        }

        // GET: Ports1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ports = await _context.Ports.FindAsync(id);
            if (ports == null)
            {
                return NotFound();
            }
            return View(ports);
        }

        // POST: Ports1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ISA,GS,ST,Big,N1,N3,N4")] Ports ports)
        {
            if (id != ports.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ports);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PortsExists(ports.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ports);
        }

        // GET: Ports1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ports = await _context.Ports
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ports == null)
            {
                return NotFound();
            }

            return View(ports);
        }

        // POST: Ports1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ports = await _context.Ports.FindAsync(id);
            _context.Ports.Remove(ports);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PortsExists(int id)
        {
            return _context.Ports.Any(e => e.Id == id);
        }
    }
}
