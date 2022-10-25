using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _1.DAL.DomainClass
{
    [Table("HoaDon")]
    [Index("Ma", Name = "UQ__HoaDon__3214CC9E6875CF4A", IsUnique = true)]
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        [Key]
        public Guid Id { get; set; }
        [Column("IdKH")]
        public Guid? IdKh { get; set; }
        [Column("IdNV")]
        public Guid? IdNv { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Ma { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayThanhToan { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayShip { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayNhan { get; set; }
        public int? TinhTrang { get; set; }
        [StringLength(50)]
        public string? TenNguoiNhan { get; set; }
        [StringLength(100)]
        public string? DiaChi { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? Sdt { get; set; }

        [ForeignKey("IdKh")]
        [InverseProperty("HoaDons")]
        public virtual KhachHang? IdKhNavigation { get; set; }
        [ForeignKey("IdNv")]
        [InverseProperty("HoaDons")]
        public virtual NhanVien? IdNvNavigation { get; set; }
        [InverseProperty("IdHoaDonNavigation")]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
