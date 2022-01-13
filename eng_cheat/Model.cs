﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace eng_cheat
{
    public class VerbContext : DbContext
    {
        public System.Data.Entity.DbSet<Verb> Verbs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=verbsDB.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Verb>().ToTable("Verbs");
        }
    }

    public class Verb
    {
        public int VerbId { get; set; }
        public string Infinitive { get; set; }
        public string Simple { get; set; }
        public string Participle { get; set; }
    }
}