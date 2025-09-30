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
    public class IndexModel : PageModel
    {
        private readonly Barlangok.Data.BarlangokDb _context;

        public IndexModel(Barlangok.Data.BarlangokDb context)
        {
            _context = context;
        }

        public IList<BarlangModel> Barlangok { get;set; } = default!;
        public IList<string> Telepulesek { get; set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string ValasztottTelepules { get; set; } = "";

        public async Task OnGetAsync()
        {
            Barlangok = await _context.barlangok.ToListAsync();
            Telepulesek = Barlangok.Select(x => x.Telepules).Distinct().ToList();
            if (ValasztottTelepules != "")
            {
                Barlangok = Barlangok.Where(x => x.Telepules == ValasztottTelepules).ToList();
            }
        }
    }
}
