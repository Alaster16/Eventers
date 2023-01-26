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
                 CompanyName = "Superman123",
                 CompanyEmail = "Superayam@gmail.com",
                 CompanyAdress = "Changi Prison",
                 CompanyNumber = 93572345,
             },
             new Company
             {
                 Id = 2,
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 UpdatedBy = "System",
                 CompanyID = 565866,
                 CompanyName = "Batman123",
                 CompanyEmail = "Superpork@gmail.com",
                 CompanyAdress = "Dairy Farm",
                 CompanyNumber = 93657364,
             }
             );
        }


    }

}