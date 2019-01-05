namespace QLDoanVien.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DoanVienDatabase : DbContext
    {
        public DoanVienDatabase()
            : base("name=DoanVienDatabase")
        {
        }

        public virtual DbSet<DOANVIEN> DOANVIENs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
