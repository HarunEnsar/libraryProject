using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace library.Model
{
    public class kutuphaneci
    {
        [Key]
        public int Id { get; set; }
        [BindProperty]
        public string? UserName { get; set; }
        [BindProperty]
        public string? PassWord { get; set; }
        
        public static List<kutuphaneci> kutuphaneCi = new List<kutuphaneci>
        {
            new kutuphaneci { Id=1, UserName="Harun", PassWord="1234",}
        };
    }
    
}
