using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _1.DAL.DomainClass
{
    [Table("SanPham")]
    [Index("Ma", Name = "UQ__SanPham__3214CC9ED6F8BB84", IsUnique = true)]
    public partial class SanPham
    {
        public SanPham()
        {
            ChiTietSps = new HashSet<ChiTietSp>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Ma { get; set; }
        [StringLength(30)]
        public string? Ten { get; set; }

        [InverseProperty("IdSpNavigation")]
        public virtual ICollection<ChiTietSp> ChiTietSps { get; set; }
    }
}
