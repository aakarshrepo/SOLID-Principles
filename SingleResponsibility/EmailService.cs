using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles
{
    public class EmailService
    {
        public virtual bool validateEmail(string email)
        {
            return email.Contains("@");
        }
        public void sendEmail(User message) => Console.WriteLine("send message");
    }
}
