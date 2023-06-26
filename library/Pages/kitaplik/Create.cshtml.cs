using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using library.Data;
using library.Model;
using Microsoft.AspNetCore.Hosting;

namespace library.Pages.kitaplik
{
    public class CreateModel : PageModel
    {

        [BindProperty]
        public IFormFile resim { get; set; }

        private readonly library.Data.libraryContext _context;

        public CreateModel(library.Data.libraryContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public kitapVerileri kitapVerileri { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.kitapVerileri.Add(kitapVerileri);
            await _context.SaveChangesAsync();

            if (resim != null && resim.Length > 0)
            {
                // Resim dosyasını kaydedilecek yol
                var resimYolu = Path.Combine("wwwroot", "resimler");

                // Yeni bir dosya adı oluştur
                var dosyaAdi = Path.GetRandomFileName() + Path.GetExtension(resim.FileName); var dosyaYolu = Path.Combine(resimYolu, dosyaAdi);

                // Resim dosyasını kaydet
                using (var stream = new FileStream(dosyaYolu, FileMode.Create))
                {
                    await resim.CopyToAsync(stream);
                }

                // Resim dosyasının yolunu ve diğer verileri veritabanına kaydedin

                kitapVerileri.ResimYolu = dosyaAdi;
                
            }

            //_context üzerinde yapılan değişiklikleri veritabanına asenkron bir şekilde kaydetme
            await _context.SaveChangesAsync();

            return RedirectToPage("/kitaplik/Kitaplik");
        }
    }
}
