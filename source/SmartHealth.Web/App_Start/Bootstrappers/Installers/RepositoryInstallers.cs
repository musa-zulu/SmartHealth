using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using SmartHealth.Core.Interfaces.Repositories;
using SmartHealth.DB.Repository;

namespace LendingLibrary.Web.Bootstrappers.Installers
{
    public class RepositoryInstallers : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IPatientRepository>()
                .ImplementedBy<PatientRepository>()
                .LifestylePerWebRequest());
           
        }
    }
}