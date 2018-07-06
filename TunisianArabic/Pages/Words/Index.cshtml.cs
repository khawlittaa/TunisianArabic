using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TunisianArabic.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TunisianArabic.Pages.Words
{
    public class IndexModel : PageModel
    {
        private readonly TunisianArabic.Models.WordContext _context;

        public IndexModel(TunisianArabic.Models.WordContext context)
        {
            _context = context;
        }
        public SelectList Natures;
        public IList<Word> Words { get; set; }
        public string WordNature { get; set; }

        public async Task OnGetAsync(string WordNature, string SearchString)
        {
            var allWords = from w in _context.Word
                           select w;

            IQueryable<string> natureQuery = from w in _context.Word
                                             orderby w.Nature
                                             select w.Nature;
            if (!String.IsNullOrEmpty(SearchString))
            {
                allWords = allWords.Where(w => w.EngWord.Contains(SearchString.Trim()));
            }

            if (!String.IsNullOrEmpty(WordNature))
            {
                allWords = allWords.Where(x => x.Nature.Trim() == WordNature.Trim());
            }

            Natures = new SelectList(await natureQuery.Distinct().ToListAsync());

            Words = await allWords.ToListAsync();
            // Words = await _context.Word.ToListAsync();
        }
    }
}
