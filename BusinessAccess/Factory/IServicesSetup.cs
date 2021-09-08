using BusinessAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Factory
{
    public interface IServicesSetup
    {
        Func<ICacheService> CacheServiceCreater
        { get; }
        void SetCacheServiceCreator(Func<ICacheService> Create);

        Func<IDataAccessService> DataAccessServiceCreater
        { get; }
        void SetDataAccessServiceCreator(Func<IDataAccessService> Create);
        
        Func<IEmailService> EmailServiceCreater
        { get; }
        void SetEmailServiceCreator(Func<IEmailService> Create);
        
        Func<IRandomService> RandomServiceCreater
        { get; }
        void SetRandomServiceCreator(Func<IRandomService> Create);
    }
}
