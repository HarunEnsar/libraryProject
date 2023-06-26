using library.Model;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace library.Pages
{
    public class TerminalModel : PageModel
    {
        
        [BindProperty]//yani heryerden eriþebilirsin
        public string? UserName { get; set; }//tboxdan gelen name yani UserName ile property ismi ayný olmalý
        [BindProperty]
        public string? PassWord { get; set; }//tboxdan gelen name yani Password ile property ismi ayný olmalý
        [BindProperty]
        public bool isError { get; set; }// hatanýn olup olmamasý 
      
       
        public void OnGet()
        {
            
        }
        public IActionResult OnPost()// kullanýcý ve þifreyi post edicez
        {
            var uname = UserName;
            var psw = PassWord;

            var admin = kutuphaneci.kutuphaneCi.FirstOrDefault(x => x.UserName == uname && x.PassWord == psw);
            if (admin != null)
            {
               
                return RedirectToPage("/kitaplik/Kitaplik", new { adminId = admin.Id});
            }
            else//hata olduðunda sayfaya dönsün
            {
                isError = true;
                return Page();


            }


        }
    }
}
