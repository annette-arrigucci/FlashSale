namespace FlashSale.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FlashSale.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(FlashSale.Models.ApplicationDbContext context)
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
            var db = new ApplicationDbContext();
            var userManager = new UserManager<ApplicationUser>(
            new UserStore<ApplicationUser>(context));
            if (!context.Users.Any(u => u.Email == "annette.arrigucci@gmail.com"))
            {
                var newAdmin = new Admin
                {
                    UserName = "annette.arrigucci@gmail.com",
                    DisplayName = "Annette Arrigucci",
                    Email = "annette.arrigucci@gmail.com",
                    PhoneNumber = "999-999-9999",
                    Address = "100 Anywhere Road",
                    City = "Evans",
                    State = "Georgia",
                    Zip = "30809"
                };
                userManager.Create(newAdmin, "Abc&123!");
                db.Admins.Add(newAdmin);
            }

            if (!context.Users.Any(u => u.Email == "lgritchie57@gmail.com"))
            {
                var newGrower = new Grower
                {
                    UserName = "lgritchie57@gmail.com",
                    Email = "lgritchie57@gmail.com",
                    DisplayName = "H and L Farms And Stable",
                    PhoneNumber = "843-263-7063",
                    Address = "111 Hephzibah Circle",
                    City = "Hephzibah",
                    State = "Georgia",
                    Zip = "30809",
                    TaxId = 999999999
                };
                userManager.Create(newGrower, "Abc&123!");
                db.Growers.Add(newGrower);
            }

            if (!context.Users.Any(u => u.Email == "a.customer@gmail.com"))
            {
                var newCustomer = new Customer
                {
                    UserName = "a.customer@gmail.com",
                    Email = "a.customer@gmail.com",
                    DisplayName = "John Tom",
                    PhoneNumber = "999-999-9999",
                    Address = "1100 Broad Street",
                    City = "Augusta",
                    State = "Georgia",
                    Zip = "30809"
                };
                userManager.Create(newCustomer, "Abc&123!");
                db.Customers.Add(newCustomer);
            }
            if (!context.Users.Any(u => u.Email == "a.charity@gmail.com"))
            {
                var newCharity = new Charity
                {
                    UserName = "a.charity@gmail.com",
                    Email = "a.charity@gmail.com",
                    DisplayName = "Local Food Bank",
                    PhoneNumber = "999-999-9999",
                    Address = "1100 Washington Road",
                    City = "Augusta",
                    State = "Georgia",
                    Zip = "30809",
                    TaxId = 888888888
                };
                userManager.Create(newCharity, "Abc&123!");
                db.Charities.Add(newCharity);
            }
        }
    }
}
