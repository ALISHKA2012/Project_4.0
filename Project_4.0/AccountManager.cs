using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Project_4._0
{
    public static class AccountManager
    {
        public static readonly string _email = "alicookerminecraftbro345@gmail.com";
        public static readonly string _password = "Tipassword123456789";
        private static SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
        private static readonly string _mailSubject = "Code Confirmation for SmartApp";
        public static event Action DisplayConfirmationForm;


        public static string ConfirmationCode { get; private set; }

        static AccountManager()
        {

            smtpClient.Credentials = new NetworkCredential(_email, _password);
            smtpClient.EnableSsl = true;


        }
        public static void SendMail(string receiver)
        {

            string message = CreateMessage();
            smtpClient.Send(_email, receiver, _mailSubject, message);
            DisplayConfirmationForm();
        }
        private static string CreateMessage()
        {
            string code = CreateConfirmationCode();
            ConfirmationCode = code;
            return $"Dear User, your confirmation code is {code}";
        }
        private static string CreateConfirmationCode()
        {
            return new Random().Next(1000000, 9999999).ToString();
        }
    }
}
