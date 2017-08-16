using SmartHealth.Core.Domain;
using SmartHealth.DB.Mappings;
using System.Data.Entity;

namespace SmartHealth.DB
{
    public interface ISmartHealthDbContext
    {
        IDbSet<Patient> Patient { get; set; }
        int SaveChanges();
    }
    public class SmartHealthDbContext : DbContext, ISmartHealthDbContext
    {
        static SmartHealthDbContext()
        {
            Database.SetInitializer<SmartHealthDbContext>(null);
        }

        public SmartHealthDbContext(string nameOrConnectionString = null)
            : base(nameOrConnectionString ?? "Name=SmarthHealthWebContext")
        {
            // Data Source=MUSA;Initial Catalog=SmarthHealth;User ID=sa
        }

        public IDbSet<Patient> Patient { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var config = modelBuilder.Configurations;
            config.Add(new PatientMap());
        }
    }
}
