namespace FurnitureOrder.dataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SpecificationMaterial")]
    public partial class SpecificationMaterial
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string product { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string material { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int quantity { get; set; }

        public virtual Material Material1 { get; set; }

        public virtual Product Product1 { get; set; }
    }
}
