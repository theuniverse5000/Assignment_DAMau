using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _2.BUS.ViewModels
{
    public class KhachHangView
    {
        public Guid Id { get; set; }
      
        public string? Ma { get; set; }
      
        public string? Ten { get; set; }
    
        public string? TenDem { get; set; }
   
        public string? Ho { get; set; }
    
        public DateTime? NgaySinh { get; set; }
    
        public string? Sdt { get; set; }
  
        public string? DiaChi { get; set; }

        public string? ThanhPho { get; set; }

        public string? QuocGia { get; set; }
      
        public string? MatKhau { get; set; }

    }
}
