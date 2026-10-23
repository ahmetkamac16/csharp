using System.Data.Entity.Migrations;

namespace Layered_Architecture.DataAccessLayer.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Layered_Architecture.DataAccessLayer.Context.ExampleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Layered_Architecture.DataAccessLayer.Context.ExampleContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
