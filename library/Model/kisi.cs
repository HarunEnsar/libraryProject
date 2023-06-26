using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace library.Model
{
    public class kisi
    {
        [Key]
        public int aliciId { get; set; }
        [BindProperty]
        public string? alici_no { get; set; }
        [BindProperty]
        public string? Password { get; set; }
        

    }
}
