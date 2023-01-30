using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventers.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eventers.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
             new Staff
             {
                 Id = 1,
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 UpdatedBy = "System",
                 StaffID = 357683,
                 StaffName = "Alaster",
                 StaffEmail = "Alaster@gmail.com",
                 StaffNumber = 86843757,
             },
             new Staff
             {
                 Id = 2,
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 UpdatedBy = "System",
                 StaffID = 657485,
                 StaffName = "Ansel Soh",
                 StaffEmail = "AnselSoh@gmail.com",
                 StaffNumber = 93768486,
             }
             );
        }
    }
}
