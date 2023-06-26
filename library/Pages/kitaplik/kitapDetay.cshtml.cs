using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using library.Data;
using library.Model;

namespace library.Pages.kitaplik
{
    public class kitapDetayModel : PageModel
    {
        [BindProperty(Name = "kutuphaneciMi", SupportsGet = true)]
        public bool isKutuphaneci { get; set; }

        private readonly library.Data.libraryContext _context;

        public kitapDetayModel(library.Data.libraryContext context)
        {
            _context = context;
        }

        public kitapVerileri kitapVerileri { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            kitapVerileri = await _context.kitapVerileri.FirstOrDefaultAsync(m => m.kitap_no == id);

            if (kitapVerileri == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
