using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace introDotNetCore1.Models
{
    public class Urun
    {
        [Required(ErrorMessage ="Ad dolu olmalı.")] //AD prop'u boş olamaz, şu hata mesajını dön. Ürün insteance'ı kullanılacaksa.
        [MaxLength(50)] //attribute bunlar. Back-end'deki validasyonu yapıyoruz.
        public string Ad { get; set; } //input nameleriyle aynı olduğu için direkt olarak UrunEkle html'indeki aynı isimdeki değerlere atanan değerler bunlara eşitleniyor.
        [Required(ErrorMessage ="Fiyat dolu olmalı.")]
        [DataType(DataType.Currency)]
        public double? Fiyat { get; set; } //veritiplerinin de aynı olması gerekli.
        [Required(ErrorMessage ="Açıklama dolu olmalı.")] //bu denetlemeler sunucu tarafında değil. 
        public string Aciklama { get; set; } //urunekle html tarafından bind edildi. bunun adı Model Binding

    }
}
