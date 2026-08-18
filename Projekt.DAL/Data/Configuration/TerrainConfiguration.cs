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
    internal class TerrainConfiguration : IEntityTypeConfiguration<Terrain>
    {
        public void Configure(EntityTypeBuilder<Terrain> builder)
        {
            builder.HasKey(t => t.Id);

            builder.HasOne(t=>t.SportCentar)
                .WithMany(sc => sc.Terrains)
                .HasForeignKey(t => t.SportCentarId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.SportType)
                .WithMany(st => st.Terrains)
                .HasForeignKey(t => t.SportTypeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
