using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class CTSPRepositories : ICTSPRepositories
    {
        private FpolyDBContext context;
        public CTSPRepositories()
        {
            context = new FpolyDBContext();
        }
        public bool Add(ChiTietSp ctsp)
        {
            if (ctsp == null)
                return false;
            context.ChiTietSps.Add(ctsp);
            context.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietSp ctsp)
        {
            if (ctsp == null) return false;
            var thao = context.ChiTietSps.FirstOrDefault(a => a.Id == ctsp.Id);
            context.Remove(thao);
            context.SaveChanges();
            return true;
        }

        public List<ChiTietSp> GetAll()
        {
            return context.ChiTietSps.ToList();
        }

        public bool Update(ChiTietSp ctsp)
        {
            if (ctsp == null) return false;
            var thao = context.ChiTietSps.FirstOrDefault(a => a.Id == ctsp.Id);
            //thao.IdSp = ctsp.IdSp;
            //thao.IdNsx=ctsp.IdNsx;
            //thao.IdMauSac=ctsp.IdMauSac;
            //thao.IdDongSp=ctsp.IdDongSp;
            /// Khóa phụ 
            thao.NamBh = ctsp.NamBh;
            thao.MoTa = ctsp.MoTa;
            thao.SoLuongTon = ctsp.SoLuongTon;
            thao.GiaNhap = ctsp.GiaNhap;
            thao.GiaBan = ctsp.GiaBan;
            context.Update(thao);
            context.SaveChanges();
            return true;
        }
    }
}
