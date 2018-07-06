using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TunisianArabic.Models;

namespace TunisianArabic.Pages.Words
{
    public class DetailsModel : PageModel
    {
        private readonly TunisianArabic.Models.WordContext _context;

        public DetailsModel(TunisianArabic.Models.WordContext context)
        {
            _context = context;
        }

        public Word Word { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Word = await _context.Word.SingleOrDefaultAsync(m => m.ID == id);

            if (Word == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
