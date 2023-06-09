﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SMK.Infrastructure.Entities;

namespace SMK.Infrastructure.Context
{
    public class CargueiroContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public CargueiroContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MinerioCargueiro>().HasKey(sc => new { sc.MinerioId, sc.CargueiroId });
        }

        public DbSet<Cargueiro> Cargueiros { get; set; }
        public DbSet<Minerio> Minerios { get; set; }

    }
}
