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
    public class KitaplikModel : PageModel
    {
        [BindProperty(Name = "kutuphaneciMi", SupportsGet = true)]
        public bool isKutuphaneci { get; set; }
        [BindProperty(Name = "kutuphaneci", SupportsGet = true)]
        public bool Kutuphaneci { get; set; }
        private readonly library.Data.libraryContext _context;

        public KitaplikModel(libraryContext context) => _context = context;

        public IList<kitapVerileri> kitapVerileri { get;set; }

        public async Task OnGetAsync()
        {
            kitapVerileri = await _context.kitapVerileri.ToListAsync();
           

        }
    }
}
