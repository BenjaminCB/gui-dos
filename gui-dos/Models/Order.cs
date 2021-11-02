using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
using MailKit.Net.Smtp;
using MimeKit;

namespace gui_dos.Models
{
    [Table("orders")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public OrderStatus Status { get; set; }
        public int Price { get; set; }
        public DateTime DateOrdered { get; set; }
        public DateTime Deadline { get; set; }
        public string Comment { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<GiftBasket> GiftBaskets { get; set; }
        public List<Change> Changelog { get; set; }

        public void SendStatusMail()
        {
            var mailMessage = new MimeMessage();
            mailMessage.From.Add(new MailboxAddress("Isvaerftet", "noreply@Isvaerftet.dk"));
            mailMessage.To.Add(new MailboxAddress(Name, Email));
            mailMessage.Subject = "Din odre er nu " + Status;
            mailMessage.Body = new TextPart("plain")
            {
                Text = $"Hej, {Name} din odre er nu {Status}"
            };

            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Connect ("smtp.gmail.com", 465, true);
                smtpClient.Authenticate("Username", "Password");
                smtpClient.Send(mailMessage);
                smtpClient.Disconnect(true);
            }
        }
    }
}
