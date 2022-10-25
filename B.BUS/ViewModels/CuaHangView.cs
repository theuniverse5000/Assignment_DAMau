using _1.DAL.DomainClass;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace _2.BUS.ViewModels
{
    public class CuaHangView
    {
        public Guid Id { get; set; }
      
        public string? Ma { get; set; }
      
        public string? Ten { get; set; }
     
        public string? DiaChi { get; set; }
        
        public string? ThanhPho { get; set; }
    
        public string? QuocGia { get; set; }
    }
}
