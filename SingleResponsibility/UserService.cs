using SOLID_Principles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text;

namespace SOLID_Principles.SingleResponsibility
{
    public class UserService
    {

        public void register(string email, string password)
        {
            var emailService = new EmailService();
            if (!emailService.validateEmail(email))
                throw new ValidationException("Email is not an email");
            var user = new User(email, password);

            emailService.sendEmail(user);
        }

        public void login(string email, string password)
        {
            Console.WriteLine("Login");
        }

        //public virtual bool ValidateEmail(string email)
        //{
        //    return email.Contains("@");
        //}
        //public void SendEmail(User message) => Console.WriteLine("send message");
    }
}
