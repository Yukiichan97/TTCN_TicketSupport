﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;

namespace TicketSupport.Areas.Admin
{
    public static class EmailHelper
    {
        public static void SendEmail(string toEmail, string subject, string body)
        {
            // Đọc cấu hình từ Web.config
            var fromAddress = new MailAddress("ngotrungtin1992003@gmail.com", "Ticket Support Team");
            var toAddress = new MailAddress(toEmail);
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com", // Máy chủ SMTP
                Port = 587,             // Cổng SMTP
                EnableSsl = true,       // Kích hoạt SSL
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("ngotrungtin1992003@gmail.com", "0906A-z991A-z635")
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true // Nếu bạn muốn gửi HTML
            })
            {
                smtp.Send(message);
            }
        }
    }
}