using library.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace library.Pages
{
    public class aliciModel : PageModel
    {
        [BindProperty]//yani heryerden eriþebilirsin
        public string? alici_no { get; set; }//tboxdan gelen name yani UserName ile property ismi ayný olmalý
        [BindProperty]
        public string? Password { get; set; }//tboxdan gelen name yani Password ile property ismi ayný olmalý
        [BindProperty]
        public bool isError { get; set; }// hatanýn olup olmamasý 
        [BindProperty(Name ="kutuphaneciMi")]
        public bool isKutuphaneci { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            var aliciNo = alici_no;
            var psw=Password;

            var alici=kisiler.kisiListe.FirstOrDefault(x=>x.alici_no==aliciNo && x.Password==psw);
            if (alici != null)// null deðilse yani deðerler geldiyse
            {
                isKutuphaneci = false;
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
