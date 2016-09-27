using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using FormularioContato.Models;

namespace gabior.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public void EnviarEmail(EmailModel Email)
        {
            try
            {
                MailMessage MailMessage = new MailMessage();
                MailMessage.To.Add(Email.Para);
                MailMessage.From = new MailAddress(Email.De);
                MailMessage.Subject = Email.Assunto;
                MailMessage.Body = Email.Mensagem;
                MailMessage.IsBodyHtml = true;

                SmtpClient SmtpClient = new SmtpClient("smtp.gmail.com", 587);
                SmtpClient.UseDefaultCredentials = false;
                SmtpClient.Credentials = new NetworkCredential("gabior@gabior.com.br", "sroczynski");
                SmtpClient.EnableSsl = true;
                SmtpClient.Send(MailMessage);
            }
            catch
            {
                ViewBag.Erro = true;
            }
        }


    }
}
