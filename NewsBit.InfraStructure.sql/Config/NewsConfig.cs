using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NB.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsBit.InfraStructure.sql.Config
{
   public class NewsConfig : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News>builder)
        {

            builder.Property(a => a.LitleTitle).HasMaxLength(15).IsRequired();
            builder.Property(a => a.NewsTitle).HasMaxLength(500).IsRequired();
        }

    }

}
