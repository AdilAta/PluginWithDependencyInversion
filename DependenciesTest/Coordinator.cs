using Business.Factory;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependenciesTest.Web
{
    /// <summary>
    /// Note  Coordinator can go as separate package too
    /// </summary>
    public class Coordinator
    {
        public bool InitializeServicesForBusiness()
        {
            EmailService.Initializer selfInitializer = new EmailService.Initializer();
            selfInitializer.SelfInitialize();

            IServicesSetup businessServicesSetup = MyServicesSetup.CreateInstance();
            businessServicesSetup.SetDataAccessServiceCreator(() => new DataAccessService());

            IServicesSetup cacheServicesSetup = MyServicesSetup.CreateInstance();
            businessServicesSetup.SetCacheServiceCreator(() => new CacheService.CacheService());

            IServicesSetup randomServiceCreator = MyServicesSetup.CreateInstance();
            businessServicesSetup.SetRandomServiceCreator(() => new SomeRandomService.SomeRandomService());

            return true;

        }

    }
}
