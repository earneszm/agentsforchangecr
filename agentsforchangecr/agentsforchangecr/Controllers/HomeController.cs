using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using agentsforchangecr.Models;
using System.Net;

namespace agentsforchangecr.Controllers
{
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

        public ActionResult Impact()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult FAQ()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Testimonial()
        {
            ViewBag.Message = "Your application description page.";
            
            return View();
        }

        private void SendEmail(LeadForm lead)
        {
            SmtpClient smtpClient = new SmtpClient();
            try
            {
                smtpClient.Host = System.Configuration.ConfigurationManager.AppSettings["SMTPserver"];
                smtpClient.Port = 25;
                //smtpClient.Timeout = 10000;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("admin@mattplusrebecca.com", "plastik5");
                              

                string subject = "New Lead!";
                string body = "some lead information here";

                MailMessage mailMessage = new MailMessage("noreply@agentsforchangecr.com", "zach.earnest@gmail.com", subject, body);

                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
            }
        }
    }
}