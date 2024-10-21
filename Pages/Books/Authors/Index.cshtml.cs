using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Stance_George_Lab2.Data;
using Stance_George_Lab2.Models;

namespace Stance_George_Lab2.Pages.Books.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Stance_George_Lab2.Data.Stance_George_Lab2Context _context;

        public IndexModel(Stance_George_Lab2.Data.Stance_George_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}
