using Eventers.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventers.Server.Configurations.Entities
{
    public class CompanySeedConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
             new Company
             {
                 Id = 1,
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 UpdatedBy = "System",
                 CompanyID = 867375,
                 CompanyName = "Razer",
                 CompanyEmail = "Razer@gmail.com",
                 CompanyAdress = "1 One-north Cres, Singapore 138538",
                 CompanyNumber = 65052188
             },
             new Company
             {
                 Id = 2,
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 UpdatedBy = "System",
                 CompanyID = 565866,
                 CompanyName = "Xtreme Solution Pte Ltd",
                 CompanyEmail = "Xtreme@gmail.com",
                 CompanyAdress = "Sim Lim Square, #02-21 Rochor Canal Rd, 188504",
                 CompanyNumber = 63389566
             }
             );
        }


    }

}