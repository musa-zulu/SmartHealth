using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace SmartHealth.Web.Bootstrappers.Installers
{
    public class EntityFrameworkInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //container.Register(Component.For<ILendingLibraryDbContext>()
              //  .ImplementedBy<LendingLibraryDbContext>()
                //.LifestylePerWebRequest());
        }
    }
}