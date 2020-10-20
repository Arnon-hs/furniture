namespace FurnitureOrder.dataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Equipment")]
    public partial class Equipment
    {
        [Key]
        [StringLength(50)]
        public string marking { get; set; }

        [StringLength(50)]
        public string type { get; set; }

        [StringLength(50)]
        public string characteristics { get; set; }

        [Required]
        [StringLength(10)]
        public string name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data { get; set; }

        public virtual TypeOfEquipment TypeOfEquipment { get; set; }
    }
}
