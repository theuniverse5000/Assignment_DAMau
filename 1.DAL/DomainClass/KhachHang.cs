using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _1.DAL.DomainClass
{
    [Table("KhachHang")]
    [Index("Ma", Name = "UQ__KhachHan__3214CC9EE78F639B", IsUnique = true)]
    public partial class KhachHang
    {
        public KhachHang()
        {
            GioHangs = new HashSet<GioHang>();
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Ma { get; set; }
        [StringLength(30)]
        public string? Ten { get; set; }
        [StringLength(30)]
        public string? TenDem { get; set; }
        [StringLength(30)]
        public string? Ho { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? Sdt { get; set; }
        [StringLength(100)]
        public string? DiaChi { get; set; }
        [StringLength(50)]
        public string? ThanhPho { get; set; }
        [StringLength(50)]
        public string? QuocGia { get; set; }
        [Unicode(false)]
        public string? MatKhau { get; set; }

        [InverseProperty("IdKhNavigation")]
        public virtual ICollection<GioHang> GioHangs { get; set; }
        [InverseProperty("IdKhNavigation")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
