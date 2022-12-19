namespace GUI_App
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONHANG")]
    public partial class DONHANG
    {
        [Key]
        [StringLength(10)]
        public string MaDH { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNV { get; set; }

        [Required]
        [StringLength(12)]
        public string CCCDGui { get; set; }

        [Required]
        [StringLength(12)]
        public string CCCDNhan { get; set; }

        [StringLength(100)]
        public string DiaChiGui { get; set; }

        [StringLength(100)]
        public string DiaChiNhan { get; set; }

        [StringLength(200)]
        public string MieuTa { get; set; }

        public double? KhoiLuong { get; set; }

        public double? KichThuoc { get; set; }

        public double? Cuoc { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual KHACHHANG KHACHHANG1 { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
