﻿using Microsoft.EntityFrameworkCore;
using NB.Core.Entities;
using NewsBit.InfraStructure.sql.Config;
using System;

namespace NewsBit.InfraStructure.sql
{
    public class NewsContext : DbContext
    {
        public NewsContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NewsConfig());
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<News> News { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Media> Medias { get; set; }
    }
}
