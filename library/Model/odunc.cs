using System.ComponentModel.DataAnnotations;

namespace library.Model
{
    public class odunc
    {
        [Key]
        public int alıcıId { get; set; }


        [Display(Name = "Alıcı No")]
        public string? alici_no { get; set; }
        
        [Display(Name = "Başlık")]
        public string? Baslik { get; set; }

        [Display(Name = "Kitap No")]
        public int kitap_no { get; set; }

        [Display(Name = "Ödünç Alınma Zamanı")]
        public DateTime OduncAlinmaZamani { get; set; } = DateTime.Now;
    }
}
