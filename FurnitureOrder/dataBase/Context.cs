namespace FurnitureOrder.dataBase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context2")
        {
        }

        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<Furniture> Furniture { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<provider> provider { get; set; }
        public virtual DbSet<SpecificationAssemblyUnit> SpecificationAssemblyUnit { get; set; }
        public virtual DbSet<SpecificationOperation> SpecificationOperation { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TypeOfEquipment> TypeOfEquipment { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<SpecificationFurniture> SpecificationFurniture { get; set; }
        public virtual DbSet<SpecificationMaterial> SpecificationMaterial { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipment>()
                .Property(e => e.marking)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment>()
                .Property(e => e.characteristics)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<Furniture>()
                .HasMany(e => e.SpecificationFurniture)
                .WithRequired(e => e.Furniture1)
                .HasForeignKey(e => e.furniture)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Material>()
                .HasMany(e => e.SpecificationMaterial)
                .WithRequired(e => e.Material1)
                .HasForeignKey(e => e.material)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Product1)
                .HasForeignKey(e => e.product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.SpecificationAssemblyUnit)
                .WithRequired(e => e.Product1)
                .HasForeignKey(e => e.product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.SpecificationAssemblyUnit1)
                .WithRequired(e => e.Product2)
                .HasForeignKey(e => e.unit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.SpecificationFurniture)
                .WithRequired(e => e.Product1)
                .HasForeignKey(e => e.product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.SpecificationMaterial)
                .WithRequired(e => e.Product1)
                .HasForeignKey(e => e.product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.SpecificationOperation)
                .WithRequired(e => e.Product1)
                .HasForeignKey(e => e.product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<provider>()
                .HasMany(e => e.Furniture)
                .WithOptional(e => e.provider)
                .HasForeignKey(e => e.mainProvider);

            modelBuilder.Entity<provider>()
                .HasMany(e => e.Material)
                .WithOptional(e => e.provider)
                .HasForeignKey(e => e.mainProvider);

            modelBuilder.Entity<TypeOfEquipment>()
                .HasMany(e => e.Equipment)
                .WithOptional(e => e.TypeOfEquipment)
                .HasForeignKey(e => e.type);

            modelBuilder.Entity<TypeOfEquipment>()
                .HasMany(e => e.SpecificationOperation)
                .WithOptional(e => e.TypeOfEquipment)
                .HasForeignKey(e => e.typeProduct);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Order1)
                .WithRequired(e => e.User1)
                .HasForeignKey(e => e.manager)
                .WillCascadeOnDelete(false);
        }
    }
}
