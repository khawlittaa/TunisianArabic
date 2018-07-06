using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TunisianArabic.Models;

namespace TunisianArabic.Pages.Words
{
    public class CreateModel : PageModel
    {
        private readonly TunisianArabic.Models.WordContext _context;

        public CreateModel(TunisianArabic.Models.WordContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Word Word { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Word.Add(Word);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}