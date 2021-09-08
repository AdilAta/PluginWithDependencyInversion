using Business;
using Business.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmailService
{
    public class Initializer
    {
        public bool SelfInitialize()
        {
            IServicesSetup setup = MyServicesSetup.CreateInstance();
            setup.SetEmailServiceCreator(CreateEmailService);
            return true;
        }

        public IEmailService CreateEmailService()
        {
            return new EmailService();
        }
    }
}
