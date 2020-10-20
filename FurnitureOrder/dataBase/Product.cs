namespace FurnitureOrder.dataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Order = new HashSet<Order>();
            SpecificationAssemblyUnit = new HashSet<SpecificationAssemblyUnit>();
            SpecificationAssemblyUnit1 = new HashSet<SpecificationAssemblyUnit>();
            SpecificationFurniture = new HashSet<SpecificationFurniture>();
            SpecificationMaterial = new HashSet<SpecificationMaterial>();
            SpecificationOperation = new HashSet<SpecificationOperation>();
        }

        [Key]
        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string size { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecificationAssemblyUnit> SpecificationAssemblyUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecificationAssemblyUnit> SpecificationAssemblyUnit1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecificationFurniture> SpecificationFurniture { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecificationMaterial> SpecificationMaterial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecificationOperation> SpecificationOperation { get; set; }
    }
}
