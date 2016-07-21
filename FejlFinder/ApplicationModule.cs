namespace FejlFinder
{
    using Ninject.Modules;
    using NLog;
    using Interfaces;
    using Classes;
    using System.Configuration;
    using System;

    class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILog>().ToMethod(x =>
            {
                var scope = x.Request.ParentRequest.Service.FullName;
                var log = (ILog)LogManager.GetLogger(scope, typeof(Log));
                return log;
            });
            Bind<IDataHandler>().To<DataHandler>();
        }
    }
}
