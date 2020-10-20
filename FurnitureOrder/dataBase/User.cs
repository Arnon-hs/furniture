namespace FurnitureOrder.dataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Order = new HashSet<Order>();
            Order1 = new HashSet<Order>();
        }

        [StringLength(255)]
        public string Фамилия { get; set; }

        [StringLength(255)]
        public string Имя { get; set; }

        [StringLength(255)]
        public string Отчество { get; set; }

        [Key]
        [StringLength(255)]
        public string login { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        [StringLength(255)]
        public string role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order1 { get; set; }
    }
}
