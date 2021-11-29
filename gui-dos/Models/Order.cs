using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MailKit.Net.Smtp;
using MimeKit;
using gui_dos.Forms;

namespace gui_dos.Models
{
    ///<summary>The 'Order' class models an order made by the customer. </summary>
    [Table("orders")]
    public class Order
    {
        [Key] public int OrderId { get; set; }

        ///<summary>Gets or sets the status of the order. </summary>
        public OrderStatus Status { get; set; }

        ///<summary>Gets the total price of the order. </summary>
        public double Price { get; set; }

        ///<summary>Gets or sets the date the order was made. </summary>
        public DateTime DateOrdered { get; set; }

        ///<summary>Gets or sets the date of when the order should be finished. </summary>
        public DateTime DateDeadline { get; set; }

        ///<summary>Gets or sets the comment of the order. </summary>
        public string Comment { get; set; }

        ///<summary>Gets or sets the customer first-name of the order. </summary>
        public string FirstName { get; set; }

        ///<summary>Gets or sets the customer last-name of the order. </summary>
        public string LastName { get; set; }

        ///<summary>Gets or sets the customer email of the order. </summary>
        public string Email { get; set; }

        ///<summary>Gets or sets the customer phone number of the order. </summary>
        public string PhoneNumber { get; set; }

        ///<summary>Gets or sets the list of gift-baskets on the order. </summary>
        public List<GiftBasket> GiftBaskets { get; set; }

        ///<summary>Gets or set the list of changes made to the order. </summary>
        public List<Change> Changelog { get; set; }

        ///<summary>Gets or sets the the id used to cancel an order. </summary>
        public string CancelId { get; set; }

        public bool ShowDetails { get; set; } = false;

        public void SendStatusMail()
        {
            var mailMessage = new MimeMessage();
            mailMessage.From.Add(new MailboxAddress("Isvaerftet", "no-reply@Isvaerftet.dk"));
            mailMessage.To.Add(new MailboxAddress(FirstName + " " + LastName, Email));
            mailMessage.Subject = "Din ordre er nu " + Status;
            mailMessage.Body = new TextPart("plain")
            {
                Text = MailStringConstructor()
            };

            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Connect("send.one.com", 465, true);
                smtpClient.Authenticate("no-reply@isvaerftet.dk", "Gavekurv2021");
                smtpClient.Send(mailMessage);
                smtpClient.Disconnect(true);
            }
        }

        private string MailStringConstructor()
        {
            switch (Status)
            {
                case OrderStatus.Afventer:
                    return $"Hej {FirstName}, din odre er nu modtaget, men endnu ikke accepteret. Du vil få en mail mere når dette sker. Du kan annullere din odre på isvaerftet.dk/shop/cancel/{CancelId}";
                case OrderStatus.Accepteret:
                    return $"Hej {FirstName}, din odre er nu accepteret. Du kan lave ændringer til din odre ved at kontakte isværftet på Mail: hej@isvaerftet.dk Mobil: 22907778.";
                case OrderStatus.Afsluttet:
                    return $"Hej {FirstName}, din odre er nu færdig. Du kan hente din gavekurv ved Isværftet; Stjernepladsen 43, 9000 Aalborg.";
                case OrderStatus.Annulleret:
                    return $"Hej {FirstName}, din odre er blevet annulleret. Hvis dette er en fejl kan du kontakte på Mail: hej@isvaerftet.dk Mobil: 22907778.";
                case OrderStatus.Afhentet:
                    return $"Hej, {FirstName}, Du har nu afhentet din odre.";
                case OrderStatus.Afslået:
                    return $"Hej {FirstName}, din odre er desværre blevet afslået, dette betyder at din odre ikke bliver udarbejdet, du kan evt. kontakte isværftet på Mail: hej@isvaerftet.dk Mobil: 22907778.";
            }

            return "Der er sket en fejl i systemet, venligst kontakt isværftet på Mail: hej@isvaerftet.dk Mobil: 22907778.";
        }

        ///<summary>Constructs an order object.
        ///<summary>Constructs an order object with the specified giftbaskets.
        ///</summary>
        public Order(List<GiftBasket> giftBaskets)
        {
            GiftBaskets = giftBaskets;
            Changelog = new List<Change>();
            Status = OrderStatus.Afventer;

        }

        public void StripInformation()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            PhoneNumber = "";
        }

        public void FillInformation(OrderForm orderDetails) {
            FirstName = orderDetails.FirstName;
            LastName = orderDetails.LastName;
            Email = orderDetails.Email;
            PhoneNumber = orderDetails.PhoneNumber;
            Comment = orderDetails.Comment;
            DateOrdered = DateTime.Now;
            DateDeadline = orderDetails.Date.GetValueOrDefault();
            CancelId = orderDetails.GetHashCode().ToString();
            Status = OrderStatus.Afventer;
            Price = GiftBaskets.Aggregate(0d, (acc, gb) => acc + gb.Price);

            // TODO remove once we send emails
            Console.WriteLine(CancelId);
        }

        public override string ToString()
        {
            return $"Order #{OrderId} - Navn: {FirstName} {LastName} - Email: {Email} - tlf nr: {PhoneNumber} - Dato: {DateOrdered.ToString("dd/MM/yyyy")}";
        }
    }
}
