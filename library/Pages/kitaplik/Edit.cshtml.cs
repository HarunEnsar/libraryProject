using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using library.Data;
using library.Model;

namespace library.Pages.kitaplik
{
    public class EditModel : PageModel
    {
        private readonly library.Data.libraryContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public EditModel(library.Data.libraryContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        [BindProperty]
        public kitapVerileri kitapVerileri { get; set; }

        [BindProperty]
        public IFormFile ResimDosyasi { get; set; }

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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (ResimDosyasi != null)
            {
                // Yeni bir resim yüklenmişse işlemleri yap
                if (kitapVerileri.ResimYolu != null)
                {
                    // Eski resmi sil
                    var eskiResimYolu = Path.Combine(_webHostEnvironment.WebRootPath, "resimler", kitapVerileri.ResimYolu);
                    if (System.IO.File.Exists(eskiResimYolu))
                    {
                        System.IO.File.Delete(eskiResimYolu);
                    }
                }

                // Yeni resmi kaydet
                var resimAdi = Guid.NewGuid().ToString() + "_" + ResimDosyasi.FileName;
                var hedefYol = Path.Combine(_webHostEnvironment.WebRootPath, "resimler", resimAdi);
                using (var dosyaAkisi = new FileStream(hedefYol, FileMode.Create))
                {
                    await ResimDosyasi.CopyToAsync(dosyaAkisi);
                }

                // Veritabanında resim yolunu güncelle
                kitapVerileri.ResimYolu = resimAdi;
            }

            _context.Attach(kitapVerileri).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!kitapVerileriExists(kitapVerileri.kitap_no))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool kitapVerileriExists(int id)
        {
            return _context.kitapVerileri.Any(e => e.kitap_no == id);
        }
    }
}
