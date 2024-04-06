
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmailBombardman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string FromMail = "twqddhqo@gmail.com";
            string FromPassword = "lodihqpwdqwd";

            MailMessage message = new MailMessage();    
            message.From = new MailAddress(FromMail);
            message.Subject = "Test mail";

            message.Body = "Davaydaaa";
            List<string> recipients = new List<string>
{
    "newsfromworld00@gmail.com",
    "beyisi66@gmail.com",
    "ilkinbaba20@gmail.com"
    // Add more recipients as needed
};
            var smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(FromMail, FromPassword);
            smtpClient.EnableSsl = true;
            foreach (var recipient in recipients)
            {
                message.To.Clear(); // Clear previous recipients
                message.To.Add(new MailAddress(recipient));

                try
                {
                    smtpClient.Send(message);
                    Console.WriteLine("Email sent to: " + recipient);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed to send email to " + recipient + ": " + ex.Message);
                }

                Thread.Sleep(3000); // Wait for 3 seconds before sending the next email
            }


        }
    }
}
