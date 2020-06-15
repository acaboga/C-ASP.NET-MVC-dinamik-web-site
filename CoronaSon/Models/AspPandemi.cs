namespace CoronaSon.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AspPandemi : DbContext
    {
        public AspPandemi()
            : base("name=AspPandemi")
        {
        }

        public virtual DbSet<Neg> Neg { get; set; }
        public virtual DbSet<Poz> Poz { get; set; }
        public virtual DbSet<Test> Test { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
