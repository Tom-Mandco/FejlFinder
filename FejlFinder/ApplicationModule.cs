namespace FejlFinder
{
    using Ninject.Modules;
    using NLog;
    using Grænseflader;
    using Klasser;
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

            Bind<IFilHandleren>().To<FilHandleren>();
            Bind<IFilLæser>().To<FilLæser>();
            Bind<IFilPlacering>().To<FilPlacering>();
            Bind<IEmailForfatter>().To<EmailForfatter>();
            Bind<IEmailHandleren>().To<EmailHandleren>();
        }
    }
}
