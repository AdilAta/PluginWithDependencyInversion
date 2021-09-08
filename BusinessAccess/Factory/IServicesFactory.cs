using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Factory
{
    interface IServicesFactory
    {
        ICacheService CreateCacheService();
        IEmailService CraeteEmailService();
        IDataAccessService CreateDataAccessService();
        IRandomService CreateRandomService();
    }
}
