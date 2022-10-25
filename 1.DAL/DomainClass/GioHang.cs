using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _1.DAL.DomainClass
{
    [Table("GioHang")]
    [Index("Ma", Name = "UQ__GioHang__3214CC9E54B69272", IsUnique = true)]
    public partial class GioHang
    {
        public GioHang()
        {
            GioHangChiTiets = new HashSet<GioHangChiTiet>();
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
        [StringLength(50)]
        public string? TenNguoiNhan { get; set; }
        [StringLength(100)]
        public string? DiaChi { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? Sdt { get; set; }
        public int? TinhTrang { get; set; }

        [ForeignKey("IdKh")]
        [InverseProperty("GioHangs")]
        public virtual KhachHang? IdKhNavigation { get; set; }
        [InverseProperty("IdGioHangNavigation")]
        public virtual ICollection<GioHangChiTiet> GioHangChiTiets { get; set; }
    }
}
