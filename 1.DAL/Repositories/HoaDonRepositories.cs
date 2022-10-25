using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class HoaDonRepositories : IHoaDonRepositories
    {
        private FpolyDBContext context;
        public HoaDonRepositories()
        {
            context = new FpolyDBContext();

        }
        public bool Add(HoaDon hd)
        {
            if (hd == null) return false;
            context.HoaDons.Add(hd);
            context.SaveChanges();
            return true;
            
        }

        public bool Delete(HoaDon hd)
        {
            if (hd == null) return false;
            var thao = context.HoaDons.FirstOrDefault(a => a.Id == hd.Id);
            context.Remove(thao);
            context.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAll()
        {
            return context.HoaDons.ToList();
        }

        public bool Update(HoaDon hd)
        {
           if(hd==null) return false;
           var thao = context.HoaDons.FirstOrDefault(a => a.Id == hd.Id);
            thao.IdKh=hd.IdKh;
            thao.IdNv=hd.IdNv;
            thao.Ma=hd.Ma;
            thao.NgayTao=hd.NgayTao;
            thao.NgayThanhToan=hd.NgayThanhToan;
            thao.NgayShip=hd.NgayShip;
            thao.NgayNhan=hd.NgayNhan;
            thao.TinhTrang=hd.TinhTrang;
            thao.TenNguoiNhan=hd.TenNguoiNhan;
            thao.DiaChi=hd.DiaChi;
            thao.Sdt=hd.Sdt;
            context.Update(thao);
            context.SaveChanges();
            return true;
        }
    }
}
