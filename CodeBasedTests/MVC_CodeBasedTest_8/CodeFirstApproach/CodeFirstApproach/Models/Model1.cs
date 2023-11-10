using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CodeFirstApproach.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {

        }

        public virtual DbSet<Movy> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movy>()
                .Property(e => e.mname)
                .IsUnicode(false);
        }
    }
}
