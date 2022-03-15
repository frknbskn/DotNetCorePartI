using Microsoft.AspNetCore.Mvc;
using System;

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

        public IActionResult UrunEkle()
        {

        }
    }
}
