using Barlangok.Data;
using Barlangok.DTOs;
using Barlangok.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Barlangok.Pages
{
    public class TelepulesekModel : PageModel
    {
        private readonly BarlangokDb _ctx;

        public TelepulesekModel(BarlangokDb ctx)
        {
            _ctx = ctx;
        }
        public IList<BarlangVarosonkentDTO> barlangok { get; set; } = default!;

        public void OnGet()
        {
            barlangok = _ctx.barlangok.GroupBy(x => x.Telepules).Select(x => new BarlangVarosonkentDTO { BarlangokSzama= x.Count(), Telepules= x.Key}).ToList();
        }
    }
}
