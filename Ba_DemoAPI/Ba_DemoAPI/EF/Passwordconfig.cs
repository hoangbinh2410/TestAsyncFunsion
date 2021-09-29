using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ba_DemoAPI.EF
{
    public class Passwordconfig : IEntityTypeConfiguration<Password>
    {
        public void Configure(EntityTypeBuilder<Password> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.User).HasColumnType("char(10)");
            builder.Property(x => x.Pass).HasColumnType("char(10)");
            builder.Property(x => x.Manv).HasColumnType("char(8)");
        }
    }
}
