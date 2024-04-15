namespace RGR
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PlantVarietyModel : DbContext
    {
        public PlantVarietyModel()
            : base("name=PlantVarietyModel")
        {
        }

        public virtual DbSet<PlantTable> PlantTable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlantTable>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PlantTable>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<PlantTable>()
                .Property(e => e.Author)
                .IsUnicode(false);

            modelBuilder.Entity<PlantTable>()
                .Property(e => e.PestResistance)
                .IsUnicode(false);

            modelBuilder.Entity<PlantTable>()
                .Property(e => e.DiseaseResistance)
                .IsUnicode(false);
        }
    }
}
