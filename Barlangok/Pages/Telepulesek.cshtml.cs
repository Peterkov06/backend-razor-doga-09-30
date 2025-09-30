using Barlangok.Data;
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

        public void OnGet()
        {
        }
    }
}
