using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _2.BUS.ViewModels
{
    public class NhanVienView
    {
        public string? TenChucVu { get; set; }
        public string? TenCuaHang { get; set; }
        public Guid Id { get; set; }
       
        public string? Ma { get; set; }
      
        public string? Ten { get; set; }
     
        public string? TenDem { get; set; }
     
        public string? Ho { get; set; }
     
        public string? GioiTinh { get; set; }
     
        public DateTime? NgaySinh { get; set; }
 
        public string? DiaChi { get; set; }
      
        public string? Sdt { get; set; }
 
        public string? MatKhau { get; set; }
      
        public Guid? IdCh { get; set; }
    
        public Guid? IdCv { get; set; }

        public Guid? IdGuiBc { get; set; }
        public int? TrangThai { get; set; }
        public string TrangThaiOn { get; set; }
    }
}
