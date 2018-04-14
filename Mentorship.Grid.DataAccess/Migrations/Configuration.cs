using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using Mentorship.Grid.DataAccess.Models;

namespace Mentorship.Grid.DataAccess.Migrations
{    
    internal sealed class Configuration : DbMigrationsConfiguration<BillionairesDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(BillionairesDbContext context)
        {
            var billGates = new Billionaire
            {
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                Position = 1,
                FirstName = "Bill",
                LastName = "Gates",
                NetWorth = 86.0M,
                Age = 61,
                Nationality = "United States",
                SourcesOfWealth = new List<SourceOfWealth>()
            };
            var warrenBuffett = new Billionaire
            {
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                Position = 2,
                FirstName = "Warren",
                LastName = "Buffett",
                NetWorth = 75.6M,
                Age = 86,
                Nationality = "United States",
                SourcesOfWealth = new List<SourceOfWealth>()
            };
            var jeffBezos = new Billionaire
            {
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                Position = 3,
                FirstName = "Jeff",
                LastName = "Bezos",
                NetWorth = 72.8M,
                Age = 53,
                Nationality = "United States",
                SourcesOfWealth = new List<SourceOfWealth>()
            };
            var amancioOrtega = new Billionaire
            {
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                Position = 4,
                FirstName = "Amancio",
                LastName = "Ortega",
                NetWorth = 71.3M,
                Age = 80,
                Nationality = "Spain",
                SourcesOfWealth = new List<SourceOfWealth>()
            };
            var markZuckerberg = new Billionaire
            {
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                Position = 5,
                FirstName = "Mark",
                LastName = "Zuckerberg",
                NetWorth = 56.0M,
                Age = 32,
                Nationality = "United States",
                SourcesOfWealth = new List<SourceOfWealth>()
            };
            var carlosSlim = new Billionaire
            {
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                Position = 6,
                FirstName = "Carlos",
                LastName = "Slim",
                NetWorth = 54.5M,
                Age = 77,
                Nationality = "Mexico",
                SourcesOfWealth = new List<SourceOfWealth>()
            };
            var larryEllison = new Billionaire
            {
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                Position = 7,
                FirstName = "Larry",
                LastName = "Ellison",
                NetWorth = 52.2M,
                Age = 72,
                Nationality = "United States",
                SourcesOfWealth = new List<SourceOfWealth>()
            };
            var charlesKoch = new Billionaire
            {
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                Position = 8,
                FirstName = "Charles",
                LastName = "Koch",
                NetWorth = 48.3M,
                Age = 81,
                Nationality = "United States",
                SourcesOfWealth = new List<SourceOfWealth>()
            };
            var davidKoch = new Billionaire
            {
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                Position = 9,
                FirstName = "David",
                LastName = "Koch",
                NetWorth = 48.3M,
                Age = 76,
                Nationality = "United States",
                SourcesOfWealth = new List<SourceOfWealth>()
            };
            var michaelBloomberg = new Billionaire
            {
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                Position = 10,
                FirstName = "Michael",
                LastName = "Bloomberg",
                NetWorth = 47.5M,
                Age = 75,
                Nationality = "United States",
                SourcesOfWealth = new List<SourceOfWealth>()
            };

            var microsoft = new SourceOfWealth
            {
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                CompanyName = "Microsoft"
            };
            var berkshireHathaway = new SourceOfWealth
            {
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                CompanyName = "Berkshire Hathaway"
            };
            var amazon = new SourceOfWealth
            {
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                CompanyName = "Amazon.com"
            };
            var inditex = new SourceOfWealth
            {
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                CompanyName = "Inditex"
            };
            var zara = new SourceOfWealth
            {
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                CompanyName = "Zara"
            };
            var facebook = new SourceOfWealth
            {
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                CompanyName = "Facebook"
            };
            var americaMovil = new SourceOfWealth
            {
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                CompanyName = "América Móvil"
            };
            var grupoCarso = new SourceOfWealth
            {
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                CompanyName = "Grupo Carso"
            };
            var oracleCorporation = new SourceOfWealth
            {
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                CompanyName = "Oracle Corporation"
            };
            var kochIndustries = new SourceOfWealth
            {
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                CompanyName = "Koch Industries"
            };
            var bloombergLp = new SourceOfWealth
            {
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                CompanyName = "Bloomberg L.P."
            };

            billGates.SourcesOfWealth.Add(microsoft);
            warrenBuffett.SourcesOfWealth.Add(berkshireHathaway);
            jeffBezos.SourcesOfWealth.Add(amazon);
            amancioOrtega.SourcesOfWealth.Add(inditex);
            amancioOrtega.SourcesOfWealth.Add(zara);
            markZuckerberg.SourcesOfWealth.Add(facebook);
            carlosSlim.SourcesOfWealth.Add(americaMovil);
            carlosSlim.SourcesOfWealth.Add(grupoCarso);
            larryEllison.SourcesOfWealth.Add(oracleCorporation);
            charlesKoch.SourcesOfWealth.Add(kochIndustries);
            davidKoch.SourcesOfWealth.Add(kochIndustries);
            michaelBloomberg.SourcesOfWealth.Add(bloombergLp);

            context.Billionaires.Add(billGates);
            context.Billionaires.Add(warrenBuffett);
            context.Billionaires.Add(jeffBezos);
            context.Billionaires.Add(amancioOrtega);
            context.Billionaires.Add(markZuckerberg);
            context.Billionaires.Add(carlosSlim);
            context.Billionaires.Add(larryEllison);
            context.Billionaires.Add(charlesKoch);
            context.Billionaires.Add(davidKoch);
            context.Billionaires.Add(michaelBloomberg);
            context.SaveChanges();
        }
    }
}
