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
    public class IndexModel : PageModel
    {
        [BindProperty(Name = "kutuphaneciMi", SupportsGet = true)]
        public bool isKutuphaneci { get; set; }

        [BindProperty(SupportsGet = true)]
        public string author { get; set; } // Arama çubuğundan gelen kelimeyi alacak property
        
        [BindProperty(SupportsGet = true)]
        public string title { get; set; }

        [BindProperty(SupportsGet = true)]
        public string subject { get; set; }

        private readonly library.Data.libraryContext _context;

        public IndexModel(libraryContext context) => _context = context;

        public IList<kitapVerileri> kitapVerileri { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<kitapVerileri> kitaplar = _context.kitapVerileri;

            if (!string.IsNullOrEmpty(author))
            {
                // Arama çubuğundan gelen kelimeye göre filtreleme yapılacak
                kitaplar = kitaplar.Where(k => k.yazar.Contains(author));
            }
            

            if (!string.IsNullOrEmpty(title))
            {
                // Arama çubuğundan gelen kelimeye göre filtreleme yapılacak
                kitaplar = kitaplar.Where(k => k.baslik.Contains(title));
            }
           

            if (!string.IsNullOrEmpty(subject))
            {
                // Arama çubuğundan gelen kelimeye göre filtreleme yapılacak
                kitaplar = kitaplar.Where(k => k.konu.Contains(subject));
            }

            kitapVerileri = await kitaplar.ToListAsync();
        }
       

    }
}
