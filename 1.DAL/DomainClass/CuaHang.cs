using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _1.DAL.DomainClass
{
    [Table("CuaHang")]
    [Index("Ma", Name = "UQ__CuaHang__3214CC9E608F99CB", IsUnique = true)]
    public partial class CuaHang
    {
        public CuaHang()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Ma { get; set; }
        [StringLength(50)]
        public string? Ten { get; set; }
        [StringLength(100)]
        public string? DiaChi { get; set; }
        [StringLength(50)]
        public string? ThanhPho { get; set; }
        [StringLength(50)]
        public string? QuocGia { get; set; }

        [InverseProperty("IdChNavigation")]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
