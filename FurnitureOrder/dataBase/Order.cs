namespace FurnitureOrder.dataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int number { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime date { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(50)]
        public string product { get; set; }

        [Required]
        [StringLength(255)]
        public string customer { get; set; }

        [Required]
        [StringLength(255)]
        public string manager { get; set; }

        [Column(TypeName = "money")]
        public decimal? price { get; set; }

        [Column(TypeName = "date")]
        public DateTime? end_date { get; set; }

        [StringLength(50)]
        public string scheme { get; set; }

        public virtual Product Product1 { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
