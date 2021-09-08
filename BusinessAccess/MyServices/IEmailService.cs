using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public interface IEmailService
    {
        bool SendTestEmail(string EmailAdress);
    }
}
