using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NVC1521050560.Models
{
    public partial class NVC1521050560DbContext : DbContext
    {
        public NVC1521050560DbContext()
            : base("name=NVC1521050560DbContext")
        {
        }

        public virtual DbSet<Person> Persons { get; set; }
        //public virtual DbSet<Student> Students { get; set; }
        //public virtual DbSet<Lectures> Lectures { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Person>()
            //    .Property(e => e.PersonID)
            //    .IsUnicode(false);
            //modelBuilder.Entity<Person>()
            //    .Property(e => e.PersonName)
            //    .IsUnicode(false);
        }

        //public System.Data.Entity.DbSet<NVC1521050560.Models.Class1> Class1 { get; set; }

        //public System.Data.Entity.DbSet<NVC1521050560.Models.Student> Students { get; set; }
    }
}
