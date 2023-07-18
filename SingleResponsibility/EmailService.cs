using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles
{
    public class EmailService
    {
        public virtual bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
        public void SendEmail(User message) => Console.WriteLine("send message");
    }
}
