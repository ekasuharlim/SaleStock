using Nancy;
using Nancy.TinyIoc;
using log4net;
using Nancy.Bootstrapper;
using StoreWeb.Constant;

namespace StoreWeb.NancyConfig
{
    public class Bootstraper : DefaultNancyBootstrapper
    {

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);
            container.Register<ILog>(LogManager.GetLogger(Setting.LogInstance));
        }

        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            pipelines.OnError += (ctx, ex) =>
            {
                LogManager.GetLogger(Setting.LogInstance).Error(ex);
                return null;
            };
            base.ApplicationStartup(container, pipelines);
           
        }
    }
}
