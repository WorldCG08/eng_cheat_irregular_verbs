using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;

namespace eng_cheat
{
    public class VerbContext : DbContext
    {
        public DbSet<Verb> Verbs { get; set; }
    }

    public class Verb
    {
        public int VerbId { get; set; }
        public string Infinitive { get; set; }
        public string Simple { get; set; }
        public string Participle { get; set; }
    }
}