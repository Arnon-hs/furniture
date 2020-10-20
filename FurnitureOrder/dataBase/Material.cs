namespace FurnitureOrder.dataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Material")]
    public partial class Material
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Material()
        {
            SpecificationMaterial = new HashSet<SpecificationMaterial>();
        }

        [Key]
        [StringLength(255)]
        public string vendorCode { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string unit { get; set; }

        public double? length { get; set; }

        [StringLength(255)]
        public string quanity { get; set; }

        [StringLength(255)]
        public string type { get; set; }

        [StringLength(255)]
        public string price { get; set; }

        [StringLength(255)]
        public string GOST { get; set; }

        [StringLength(50)]
        public string mainProvider { get; set; }

        public virtual provider provider { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecificationMaterial> SpecificationMaterial { get; set; }
    }
}
