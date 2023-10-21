using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller{
        
        public IActionResult Index(){

            int saat = DateTime.Now.Hour;
            string sonuc = saat < 12 ? "Günaydın" : "İyi Günler";
            ViewData["karşılama"] = sonuc;
            ViewData["name"] = "Eren";
            ViewData["title"] = "Anasayfa";

            var MeetingApp = new MeetingInfo(){
                Id = 1,
                Location = "İstanbul Abc Kongre Merkezi",
                NumberOfPeople = 100,
                Date = new  DateTime(2024, 1, 1,20,0,0)
            };
            return View(MeetingApp);
        }
    }
}