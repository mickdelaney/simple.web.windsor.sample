using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Simple.Web.Windsor.Owin.Services;

namespace Simple.Web.Windsor.Owin.Components
{
    public class ComponentsInstaller : IWindsorInstaller
    {
        public ComponentsInstaller() { }

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Register
            (
                Classes.FromThisAssembly().BasedOn<IGet>().LifestyleScoped()
            );

            container.Register
            (
                Component.For<DataService>().LifestyleSingleton()                
                
            );
        }
    }
}