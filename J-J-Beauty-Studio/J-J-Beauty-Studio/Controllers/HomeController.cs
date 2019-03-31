using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using J_J_Beauty_Studio.Models;
using System.Net.Mail;

namespace J_J_Beauty_Studio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Courses()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult About()
        {
            //ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            //ViewData["Message"] = "Your contact page.";

            return View();
        }
        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LogIn(User login)
        {
            var user = login;
            if (user.IsAdmin())
            {
                return RedirectToAction("Index", "Admin", new { area = "" });
            }
            return View();
        }
        [HttpGet]
        public IActionResult Preservation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Preservation(Preservation preservation)
        {
            //MailMessage mail = new MailMessage("andriqnangelov@gmail.com", "jjbeautystudio@gmail.com");
            //SmtpClient client = new SmtpClient();
            //client.Port = 25;
            //client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //client.UseDefaultCredentials = false;
            //client.Host = "smtp.gmail.com";
            //mail.Subject = "this is a test email.";
            //mail.Body = "this is my test email body";
            //client.Send(mail);
            using (var db = new DbConnect())
            {
                db.preservation.Add(preservation);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        
        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
