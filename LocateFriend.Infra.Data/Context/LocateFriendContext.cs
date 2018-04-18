using Locate.Domain.Entities;
using LocateFriend.Infra.Data.EntityMapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocateFriend.Infra.Data.Context
{
    public class LocateFriendContext : DbContext
    {
        public LocateFriendContext(DbContextOptions<LocateFriendContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FriendMap());
            modelBuilder.ApplyConfiguration(new LocationMap());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Friend> Friends { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}
