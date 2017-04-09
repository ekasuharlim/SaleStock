using Nancy;
using Nancy.TinyIoc;
using log4net;

namespace ProductModules.NancyConfig
{
    public class Bootstraper : DefaultNancyBootstrapper
    {

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);
            container.Register<ILog>(LogManager.GetLogger("ProductService"));
        }
    }
}
