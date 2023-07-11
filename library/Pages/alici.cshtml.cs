using library.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace library.Pages
{
    public class aliciModel : PageModel
    {
        [BindProperty]//yani heryerden erişebilirsin
        public string? alici_no { get; set; }//tboxdan gelen name yani UserName ile property ismi aynı olmalı
        [BindProperty]
        public string? Password { get; set; }//tboxdan gelen name yani Password ile property ismi aynı olmalı
        [BindProperty]
        public bool isError { get; set; }// hatanın olup olmaması 
        
        public void OnGet()
        {

        }

        private readonly library.Data.libraryContext _context;
        public aliciModel(library.Data.libraryContext context)
        {
            _context = context;
        }

        public kisi kisiler { get; set; }

        public  async Task<IActionResult> OnPost()
        {
            var aliciNo = alici_no;
            var psw=Password;

            var alici=  _context.Kisiler.FirstOrDefault(x=>x.alici_no==aliciNo && x.Password==psw);
            if (alici != null)// null değilse yani değerler geldiyse
            {
                
                return RedirectToPage("/kitaplik/Index", new { aliciNosu = alici.alici_no });
            }
            else
            {
                isError = true;//null ise 
                return Page();
            }
            
        }

    }
}
