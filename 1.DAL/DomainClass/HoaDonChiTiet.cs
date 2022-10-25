using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _1.DAL.DomainClass
{
    [Table("HoaDonChiTiet")]
    public partial class HoaDonChiTiet
    {
        [Key]
        public Guid IdHoaDon { get; set; }
        [Key]
        [Column("IdChiTietSP")]
        public Guid IdChiTietSp { get; set; }
        public int? SoLuong { get; set; }
        [Column(TypeName = "decimal(20, 0)")]
        public decimal? DonGia { get; set; }

        [ForeignKey("IdChiTietSp")]
        [InverseProperty("HoaDonChiTiets")]
        public virtual ChiTietSp IdChiTietSpNavigation { get; set; } = null!;
        [ForeignKey("IdHoaDon")]
        [InverseProperty("HoaDonChiTiets")]
        public virtual HoaDon IdHoaDonNavigation { get; set; } = null!;
    }
}
