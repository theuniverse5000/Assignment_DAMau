using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _1.DAL.DomainClass
{
    [Table("DongSP")]
    [Index("Ma", Name = "UQ__DongSP__3214CC9ED8A1AC1B", IsUnique = true)]
    public partial class DongSp
    {
        public DongSp()
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

        [InverseProperty("IdDongSpNavigation")]
        public virtual ICollection<ChiTietSp> ChiTietSps { get; set; }
    }
}
