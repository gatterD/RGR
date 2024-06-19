namespace RGR
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Autorization")]
    public partial class Autorization
    {
        [Key]
        public int UserID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string admin_mode { get; set; }
    }
}
