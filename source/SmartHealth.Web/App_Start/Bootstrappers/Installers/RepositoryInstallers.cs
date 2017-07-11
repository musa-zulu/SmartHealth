using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace LendingLibrary.Web.Bootstrappers.Installers
{
    public class RepositoryInstallers : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //container.Register(Component.For<IItemsRepository>()
             //   .ImplementedBy<ItemsRepository>()
             //   .LifestylePerWebRequest());
           
        }
    }
}