using ASGay_Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ASGay_Portfolio.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //public ActionResult Contact()
        //{
        //    return View();
        //}
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task Contact(EmaiViewModel model)
        {
          if (ModelState.IsValid)
            {
                try
                {
                 
                    var from = model.FromEmail;
                    var email = new MailMessage(from, ConfigurationManager.AppSettings["emailto"])
                    {
                        Subject = model.Subject,
                        Body = $"<strong>{model.FromName}</strong> left message:  {model.Body}.  The user's email address is <strong>{model.FromEmail} </strong>",
                        IsBodyHtml = true
                    };
                    var svc = new PersonalEmail();
                    await svc.SendAsync(email);
                    //ViewBag.Message = "Email has been sent";
                    //return View();
                    //return File("~/contact.html", "text/html");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    await Task.FromResult(0);
                }
            }

            //return File("~/contact.html", "text/html");
        }
        public ActionResult blog()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}