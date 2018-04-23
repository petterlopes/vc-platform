using System.Data.Entity.Migrations;

namespace VirtoCommerce.Platform.Data.Infrastructure
{
    public class DbMigrationsConfigurationBase<TContext> : DbMigrationsConfiguration<TContext> where TContext : System.Data.Entity.DbContext
    {
    }
}
