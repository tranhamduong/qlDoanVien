namespace QLDoanVien.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOANVIEN")]
    public partial class DOANVIEN
    {
        [Key]
        public int maDoanVien { get; set; }

        [Required]
        [StringLength(100)]
        public string hoVaTen { get; set; }

        [Required]
        [StringLength(100)]
        public string tenGoiKhac { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngaySinh { get; set; }

        public bool gioiTinh { get; set; }

        [Required]
        [StringLength(50)]
        public string danToc { get; set; }

        [Required]
        [StringLength(50)]
        public string queQuan { get; set; }

        [Required]
        [StringLength(50)]
        public string ngheNghiepBanThan { get; set; }

        [Required]
        [StringLength(50)]
        public string trinhDoHocVan { get; set; }

        [Required]
        [StringLength(100)]
        public string chuyenMonNghiepVu { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngayVaoDoan { get; set; }

        [Required]
        [StringLength(50)]
        public string noiVaoDoan { get; set; }

        [Required]
        [StringLength(50)]
        public string sucKhoe { get; set; }

        [Required]
        public string nuocDaDi { get; set; }

        [Required]
        public string liDoDi { get; set; }

        [StringLength(15)]
        public string maChiDoan { get; set; }


    }
}
