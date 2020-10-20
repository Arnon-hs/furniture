namespace FurnitureOrder.dataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SpecificationOperation")]
    public partial class SpecificationOperation
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string product { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string operation { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int serialNumber { get; set; }

        [StringLength(50)]
        public string typeProduct { get; set; }

        public TimeSpan? operationTime { get; set; }

        public virtual Product Product1 { get; set; }

        public virtual TypeOfEquipment TypeOfEquipment { get; set; }
    }
}
