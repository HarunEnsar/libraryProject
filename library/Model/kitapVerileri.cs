using System.ComponentModel.DataAnnotations;

namespace library.Model
{
    public class kitapVerileri
    {
        [Key]
        [Display(Name ="Kitap No")]
        public int kitap_no { get; set; }
        [Display(Name = "Yazar")]
        public string? yazar { get; set; }
        [Display(Name = "Başlık")]
        public string? baslik { get; set; }
        [Display(Name = "Konu")]
        public string? konu { get; set; }
        [Display(Name = "Diğer Detaylar")]
        public string? digerDetaylar { get; set; }
        [Display(Name = "Bekletme Durumu")]
        public int bekletmeDurmu { get; set; }
        [Display(Name = "Resim Yolu")]
        public string? ResimYolu { get; set; }

       
        public int alıcıId { get; set; }

    }
}
