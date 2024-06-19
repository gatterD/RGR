namespace RGR
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PlantTable")]
    public partial class PlantTable
    {
        [Key]
        public int CustomID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [StringLength(50)]
        public string Author { get; set; }

        public int? ParentVariety { get; set; }

        public double? Productivity { get; set; }

        public int? FrostResistance { get; set; }

        [StringLength(50)]
        public string PestResistance { get; set; }

        [StringLength(50)]
        public string DiseaseResistance { get; set; }
    }
}
