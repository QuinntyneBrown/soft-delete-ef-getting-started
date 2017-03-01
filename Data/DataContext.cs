using SoftDeleteEntityFrameworkGettingStarted.Data.Helpers;
using SoftDeleteEntityFrameworkGettingStarted.Data.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace SoftDeleteEntityFrameworkGettingStarted.Data
{
    public class DataContext: DbContext
    {
        public DataContext()
            :base(nameOrConnectionString: "SoftDeleteEntityFrameworkGettingStartedDataContext")
        {

        }

        public DbSet<Game> Games { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var convention = new AttributeToTableAnnotationConvention<SoftDeleteAttribute, string>(
                "SoftDeleteColumnName",
                (type, attributes) => attributes.Single().ColumnName);

            modelBuilder.Conventions.Add(convention);

            base.OnModelCreating(modelBuilder);
        }
    }
}
