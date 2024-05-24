namespace RGR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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
