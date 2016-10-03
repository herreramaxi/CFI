namespace CFI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CFI.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CFI.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Skills.AddOrUpdate(s => s.Description,
                new Models.Skills { Id = Guid.NewGuid().ToString(), Description = "C#" },
                new Models.Skills { Id = Guid.NewGuid().ToString(), Description = "ASP.NET" },
                new Models.Skills { Id = Guid.NewGuid().ToString(), Description = "ASP.NET MVC" },
                new Models.Skills { Id = Guid.NewGuid().ToString(), Description = "ASP.NET WEB FORMS" },
                new Models.Skills { Id = Guid.NewGuid().ToString(), Description = "JAVASCRIPT" },
                new Models.Skills { Id = Guid.NewGuid().ToString(), Description = "JQUERY" },
                new Models.Skills { Id = Guid.NewGuid().ToString(), Description = "BOOTSTRAP" },
                new Models.Skills { Id = Guid.NewGuid().ToString(), Description = "CSS" },
                new Models.Skills { Id = Guid.NewGuid().ToString(), Description = "OOD" },
                new Models.Skills { Id = Guid.NewGuid().ToString(), Description = "OBJECT ORIENTED DESIGN" },
                new Models.Skills { Id = Guid.NewGuid().ToString(), Description = "SQL" },
                new Models.Skills { Id = Guid.NewGuid().ToString(), Description = "TSQL" },
                new Models.Skills { Id = Guid.NewGuid().ToString(), Description = "SOLID PRINCIPLES" }
                );


        }
    }
}
