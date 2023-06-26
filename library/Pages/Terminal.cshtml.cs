using library.Model;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace library.Pages
{
    public class TerminalModel : PageModel
    {
        
        [BindProperty]//yani heryerden eri�ebilirsin
        public string? UserName { get; set; }//tboxdan gelen name yani UserName ile property ismi ayn� olmal�
        [BindProperty]
        public string? PassWord { get; set; }//tboxdan gelen name yani Password ile property ismi ayn� olmal�
        [BindProperty]
        public bool isError { get; set; }// hatan�n olup olmamas� 
      
       
        public void OnGet()
        {
            
        }
        public IActionResult OnPost()// kullan�c� ve �ifreyi post edicez
        {
            var uname = UserName;
            var psw = PassWord;

            var admin = kutuphaneci.kutuphaneCi.FirstOrDefault(x => x.UserName == uname && x.PassWord == psw);
            if (admin != null)
            {
               
                return RedirectToPage("/kitaplik/Kitaplik", new { adminId = admin.Id});
            }
            else//hata oldu�unda sayfaya d�ns�n
            {
                isError = true;
                return Page();


            }


        }
    }
}
