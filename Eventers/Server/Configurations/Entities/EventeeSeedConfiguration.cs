using Eventers.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventers.Server.Configurations.Entities
{
    public class EventeeSeedConfiguration : IEntityTypeConfiguration<Eventee>
    {
        public void Configure(EntityTypeBuilder<Eventee> builder)
        {
            builder.HasData(
               new Eventee
               {
                   Id = 1,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System",
                   Name = "Benson",
                   Address = "Jurong East",
                   NRIC = "T4758394K",
                   DateOfBirth = 2002,
                   ContactNumber = 86118499,
                   Gender = "Male",
                   Email = "njx2002@gmail.com"
               },
                new Eventee
                {
                    Id = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    Name = "Jeff",
                    Address = "Jurong West",
                    NRIC = "T26485694H",
                    DateOfBirth = 1865,
                    ContactNumber = 96731728,
                    Gender = "Female",
                    Email = "jeffng@gmail.com"
                }
                );


        }
    }
}
