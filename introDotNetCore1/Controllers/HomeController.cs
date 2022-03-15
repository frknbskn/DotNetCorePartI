using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using introDotNetCore1.Models;

namespace introDotNetCore1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Ad = "Furkan BAŞKAN";       //viewbag static değil dynamic yapıdadır. yani sen ne verirsen ben onu eklerim diyor.
            ViewBag.Saat = DateTime.Now.Hour;   //viewbag'in artık saat diye bir özelliği var. Sadece Controller'ın index action'ı ile index view'ı arasında görülür.
            return View(); //Bütün Viewler'ın bulunduğu bir yer olmak zorunda, bunun için bir Views Klasörü açıldı.
            //kullanıcıya response olarak dönebilecek bütün veritiplerini kapsar.Yani Result bilgisi IActionResult
        }
        [HttpGet] //forma girilen değerlerin getirilmesi için
        public IActionResult UrunEkle()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult UrunEkle(Urun urun)
        {
            if (ModelState.IsValid) //bütün kurallara uyuyorsanız; modelimizi denetleme. yani ürün şartları sağlandı mı?
            {
                //koleksiyona ekle... mesela

                return RedirectToAction(nameof(Index));   //şu action'a yönlendir..
            }
            return View();
        }
    }
}
