using BusinessAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Factory
{
    /// <summary>
    /// Note: Methods in this class can be converted into Generics too
    /// </summary>
    public class MyServicesSetup : IServicesSetup
    {
        //Singleton
        private MyServicesSetup()
        {
        }

        static object _lockObject = new object();

        private static IServicesSetup _instance;

        public static IServicesSetup CreateInstance()
        {
            if (_instance == null)
            {
                lock(_lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new MyServicesSetup();
                    }
                }
            }
            return _instance;
        }

        private Func<ICacheService> cacheServiceCreater;
        public void SetCacheServiceCreator(Func<ICacheService> Create)
        {
            cacheServiceCreater = Create;
        }

        private Func<IDataAccessService> dataAccessServiceCreator;
        public void SetDataAccessServiceCreator(Func<IDataAccessService> Create)
        {
            dataAccessServiceCreator = Create;
        }

        private Func<IEmailService> emailServiceCreator;
        public void SetEmailServiceCreator(Func<IEmailService> Create)
        {
            emailServiceCreator = Create;
        }

        private Func<IRandomService> randomServiceCreator;
        public void SetRandomServiceCreator(Func<IRandomService> Create)
        {
            randomServiceCreator = Create;
        }

        public Func<ICacheService> CacheServiceCreater => cacheServiceCreater;

        public Func<IDataAccessService> DataAccessServiceCreater => dataAccessServiceCreator;

        public Func<IEmailService> EmailServiceCreater => emailServiceCreator;

        public Func<IRandomService> RandomServiceCreater => randomServiceCreator;


    }
}
