using Business.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessAccess
{
    public class BusinessLogic
    {
        public bool DemoServicesUsage()
        {
            IServicesFactory servicesFactory = new MyServicesFactory();
            servicesFactory.CraeteEmailService().SendTestEmail("test@gmail.com");
            servicesFactory.CreateCacheService().GetRecord();
            servicesFactory.CreateDataAccessService().Save();
            servicesFactory.CreateRandomService().Test();

            return true;

        }
    }
}
