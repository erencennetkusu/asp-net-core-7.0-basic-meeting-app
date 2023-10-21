using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
       
        public IActionResult Index()
        {
              ViewData["title"] = "Toplantı Bilgisi";
            return View();
        }
        public IActionResult List()
        {
              ViewData["title"] = "Katılımcı Listesi";

            ViewBag.userCount = Repostory.Users().Where(x => x.WillAttend == true).Count();

            var user = Repostory.Users();

            return View(user);
        }

         public IActionResult Apply()
        {
            ViewData["title"] = "Başvuru Formu";
            return View();
        }

   

        [HttpPost]
         public IActionResult Apply(UserInfo model)
        {

            if (ModelState.IsValid)
            {
                Repostory.CreateUser(model);
                ViewBag.userCount = Repostory.Users().Where(x => x.WillAttend == true).Count();


                return View("Thanks", model);

            }
            else
            {
                ModelState.AddModelError("", "Lütfen tüm alanları eksiksiz doldurunuz");

                return View("Apply", model);
            }
        }


        public IActionResult Details(int id)
        {

            ViewData["title"] = "Katılımcı Detay";
            return View(Repostory.GetById(id));
        }



    }
}