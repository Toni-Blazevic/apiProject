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
    internal class SportTypeConfiguration : IEntityTypeConfiguration<SportType>
    {
        public void Configure(EntityTypeBuilder<SportType> builder)
        {
            builder.HasKey(st => st.Id);
        }
    }
}
