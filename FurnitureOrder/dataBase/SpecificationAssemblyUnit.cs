namespace FurnitureOrder.dataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SpecificationAssemblyUnit")]
    public partial class SpecificationAssemblyUnit
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string product { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string unit { get; set; }

        public int quantity { get; set; }

        public virtual Product Product1 { get; set; }

        public virtual Product Product2 { get; set; }
    }
}
