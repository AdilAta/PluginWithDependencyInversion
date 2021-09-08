using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Factory
{
    public class MyServicesFactory : IServicesFactory
    {
        IServicesSetup servicesSetup = MyServicesSetup.CreateInstance();

        public IEmailService CraeteEmailService()
        {
            return servicesSetup.EmailServiceCreater();
        }

        public ICacheService CreateCacheService()
        {
            return servicesSetup.CacheServiceCreater();
        }

        public IDataAccessService CreateDataAccessService()
        {
            return servicesSetup.DataAccessServiceCreater();

        }

        public IRandomService CreateRandomService()
        {
            return servicesSetup.RandomServiceCreater();

        }
    }
}
