﻿using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace NotifyBot.Data.MySql
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.LogTo(x => Debug.WriteLine(x));

            base.OnConfiguring(dbContextOptionsBuilder);
        }
    }
}