namespace OdetoFood.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdetoFood.Models.OdeToFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "OdetoFood.Models.OdeToFoodDb";
        }

        protected override void Seed(OdetoFood.Models.OdeToFoodDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Resturants.AddOrUpdate(r => r.Name,
                new Resturant { Name = "Sabatino's", City = "Baltimore", Country = "USA" },
                new Resturant { Name = "Great Lake", City = "Baltimore", Country = "USA" },
                new Resturant
                {
                    Name = "Smaka",
                    City = "Gotherburg",
                    Country = "Sweden",
                    Reviews =
                    new List<ResturantReview> {
                        new ResturantReview { Rating=9,Body="Great Food",ReviewerName="Jimbo" }
                    }

                });

            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
