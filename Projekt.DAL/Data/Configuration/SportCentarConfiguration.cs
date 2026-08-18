using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projekt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.DAL.Data.Configuration
{
    internal class SportCentarConfiguration : IEntityTypeConfiguration<SportCentar>
    {
        public void Configure(EntityTypeBuilder<SportCentar> builder)
        {
            builder.HasKey(sc => sc.Id);
        }
    }
}
