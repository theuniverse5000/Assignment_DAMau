using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _1.DAL.DomainClass
{
    [Table("NSX")]
    [Index("Ma", Name = "UQ__NSX__3214CC9E8A33AE4E", IsUnique = true)]
    public partial class Nsx
    {
        public Nsx()
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

        [InverseProperty("IdNsxNavigation")]
        public virtual ICollection<ChiTietSp> ChiTietSps { get; set; }
    }
}
