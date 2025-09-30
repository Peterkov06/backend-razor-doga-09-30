using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Barlangok.Data;
using Barlangok.Models;

namespace Barlangok.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly Barlangok.Data.BarlangokDb _context;

        public DetailsModel(Barlangok.Data.BarlangokDb context)
        {
            _context = context;
        }

        public BarlangModel BarlangModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var barlangmodel = await _context.barlangok.FirstOrDefaultAsync(m => m.Id == id);
            if (barlangmodel == null)
            {
                return NotFound();
            }
            else
            {
                BarlangModel = barlangmodel;
            }
            return Page();
        }
    }
}
