using Locate.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocateFriend.Infra.Data.EntityMapping
{
    public class LocationMap : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.X)
                .IsRequired();

            builder.Property(c => c.Y)
                .IsRequired();

            //builder.HasOne(c => c.Friend)
            //    .WithOne(c => c.Location)
            //    .HasForeignKey<Friend>(f => f.Id);

            builder.ToTable("Locations");

        }
    }
}
