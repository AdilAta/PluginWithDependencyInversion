using Business;
using System;

namespace EmailService
{
    public class EmailService : IEmailService
    {
        public bool SendTestEmail(string EmailAdress)
        {
            return true;
        }
    }
}
