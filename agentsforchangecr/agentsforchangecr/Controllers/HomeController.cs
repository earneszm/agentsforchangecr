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

            var model = new FAQContent();

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Testimonial()
        {
            var model = new TestimonialContent();

            return View(model);
        }

        public JsonResult ContactSubmit(Contact contact)
        {
            var sendSuccess = SendEmail(contact);

            return Json(new { sent = sendSuccess });
        }

        private bool SendEmail(Contact contact)
        {
            SmtpClient smtpClient = new SmtpClient();
            try
            {
                smtpClient.Host = System.Configuration.ConfigurationManager.AppSettings["SMTPserver"];
                smtpClient.Port = 25;
                //smtpClient.Timeout = 10000;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("contact@agentsforchangecr.com", "agentsforchange");
                              

                string subject = string.Format("Request for contact from: {0} {1}", contact.FirstName, contact.LastName);
                string body = string.Format("<b>First Name:</b> {0}<br /><b>Last Name:</b> {1}<br /><b>Email:</b> {2}<br /><b>Phone #:</b> {3}<br /><b>Comments:</b> {4}",
                    contact.FirstName, contact.LastName, contact.Email, contact.Phone, contact.Comment);

                MailMessage mailMessage = new MailMessage("noreply@agentsforchangecr.com", "agentsforchangecr@gmail.com", subject, body);
                mailMessage.IsBodyHtml = true;

                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
    }
}