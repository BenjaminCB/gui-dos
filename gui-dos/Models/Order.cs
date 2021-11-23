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
        [Key]
        public int OrderId { get; set; }

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
            mailMessage.From.Add(new MailboxAddress("Isvaerftet", "noreply@Isvaerftet.dk"));
            mailMessage.To.Add(new MailboxAddress(FirstName + " " + LastName, Email));
            mailMessage.Subject = "Din odre er nu " + Status;
            mailMessage.Body = new TextPart("plain")
            {
                Text = $"Hej, {FirstName} din odre er nu {Status}"
            };

            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Connect ("smtp.gmail.com", 465, true);
                smtpClient.Authenticate("Username", "Password");
                smtpClient.Send(mailMessage);
                smtpClient.Disconnect(true);
            }
        }

        ///<summary>Constructs an order object.
        ///<summary>Constructs an order object with the specified giftbaskets.
        ///</summary>
        public Order(List<GiftBasket> giftBaskets)
        {
            GiftBaskets = giftBaskets;
            Changelog = new List<Change>();
            Status = OrderStatus.Pending;

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
            CancelId = orderDetails.GetHashCode().ToString();
            Status = OrderStatus.Pending;
            Price = GiftBaskets.Aggregate(0d, (acc, gb) => acc + gb.Price);

            // TODO remove once we send emails
            Console.WriteLine(CancelId);
        }

        public override string ToString()
        {
            return $"Order #{OrderId} - Name: {FirstName} {LastName} - Email: {Email} - Phone: {PhoneNumber} - Date Ordered: {DateOrdered.ToString("dd/MM/yyyy")}";
        }
    }
}
