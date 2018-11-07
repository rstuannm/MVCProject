namespace MVCBusiness1.DataContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MVCDataContext : DbContext
    {
        public MVCDataContext()
            : base("name=MVCDataContext")
        {
        }

        public virtual DbSet<KhachHang> KhachHangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhachHang>()
                .Property(e => e.username)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.password)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.mobile)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.email)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.adress)
                .IsFixedLength();
        }
    }
}
