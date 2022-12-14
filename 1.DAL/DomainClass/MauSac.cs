using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _1.DAL.DomainClass
{
    [Table("MauSac")]
    [Index("Ma", Name = "UQ__MauSac__3214CC9E8E3EFBA9", IsUnique = true)]
    public partial class MauSac
    {
        public MauSac()
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

        [InverseProperty("IdMauSacNavigation")]
        public virtual ICollection<ChiTietSp> ChiTietSps { get; set; }
    }
}
