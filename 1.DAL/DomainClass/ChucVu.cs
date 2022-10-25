using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _1.DAL.DomainClass
{
    [Table("ChucVu")]
    [Index("Ma", Name = "UQ__ChucVu__3214CC9E6671D4D5", IsUnique = true)]
    public partial class ChucVu
    {
        public ChucVu()
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

        [InverseProperty("IdCvNavigation")]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
