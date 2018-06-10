namespace Siteshop.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Siteshop.DAL.Entities.EFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Siteshop.DAL.Entities.EFContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            context.Users.AddOrUpdate(t => t.Id,
               new Siteshop.DAL.Entities.User
               {
                   Id = 1,
                   Login = "SergioAkira",
                   FirstName = "Sergio",
                   LastName = "Kogut",
                   Email = "sergio@gmail.com",
                   Password = "admin",
                   Role = "admin",
                   DateRegistration = DateTime.Now
               });

        }
    }
}
