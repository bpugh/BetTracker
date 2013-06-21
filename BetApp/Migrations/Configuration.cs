using BetApp.Models;

namespace BetApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BetApp.Models.BetAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BetApp.Models.BetAppContext context)
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

            context.Workouts.AddOrUpdate(
                w => w.WorkoutDate,
                new Workout{ WorkoutDate = DateTime.Now, Notes = "Ran 3 miles"},
                new Workout{ WorkoutDate = DateTime.Now, Notes = "Ran 3 miles"}
            );
        }
    }
}
