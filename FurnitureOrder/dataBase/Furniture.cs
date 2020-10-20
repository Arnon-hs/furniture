namespace FurnitureOrder.dataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Furniture")]
    public partial class Furniture
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Furniture()
        {
            SpecificationFurniture = new HashSet<SpecificationFurniture>();
        }

        [Key]
        [StringLength(255)]
        public string VendorCode { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public double? quantity { get; set; }

        [StringLength(255)]
        public string unit { get; set; }

        [StringLength(255)]
        public string type { get; set; }

        public double? price { get; set; }

        [StringLength(50)]
        public string mainProvider { get; set; }

        public virtual provider provider { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecificationFurniture> SpecificationFurniture { get; set; }
    }
}
