namespace SoftDeleteEntityFrameworkGettingStarted.Migrations
{
    using Data.Helpers;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SoftDeleteEntityFrameworkGettingStarted.Data.DataContext>
    {
        public Configuration()
        {

            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SoftDeleteEntityFrameworkGettingStarted.Data.DataContext context)
        {
            GameConfiguration.Seed(context);
        }
    }    
}
