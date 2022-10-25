using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;

namespace _2.BUS.Service
{
    public class QLSPService : IQLSPService
    {
        ICTSPRepositories ctspr;
        ISanPhamRepositories spr;
        INSXRepositories nsxr;
        IDSPRepositories dspr;
        IMauSacRepositories mausacr;

        public QLSPService()
        {
            ctspr = new CTSPRepositories();
            spr = new SanPhamRepositories();
            nsxr = new NSXRepositories();
            dspr = new DSPRepositories();
            mausacr = new MauSacRepositories();

        }
        public string AddCTSP(ChiTietSanPhamView ctspv)
        {
            if (ctspv == null) return "NOT";
            ChiTietSp thao = new ChiTietSp()
            {
                IdSp = ctspv.IdSp,
                IdNsx = ctspv.IdNsx,
                IdDongSp = ctspv.IdDongSp,
                IdMauSac = ctspv.IdMauSac,
                NamBh = ctspv.NamBh,
                MoTa = ctspv.MoTa,
                SoLuongTon = ctspv.SoLuongTon,
                GiaNhap = ctspv.GiaNhap,
                GiaBan = ctspv.GiaBan
            };
            if (ctspr.Add(thao)) return "OK";
            else return "NOT";

        }

        public string DeleteCTSP(ChiTietSanPhamView ctspv)
        {
            if (ctspv == null) return "NOT";
            ChiTietSp thao = new ChiTietSp()
            {
                Id = ctspv.Id,
            };
            if (ctspr.Delete(thao)) return "OK";
            else return "NOT";
        }
        public List<ChiTietSanPhamView> GetCTSP()
        {
            List<ChiTietSanPhamView> listctsp = new List<ChiTietSanPhamView>();
            listctsp = (
                from a in ctspr.GetAll()
                join b in spr.GetAll() on a.IdSp equals b.Id
                join c in mausacr.GetAll() on a.IdMauSac equals c.Id
                join d in dspr.GetAll() on a.IdDongSp equals d.Id
                join e in nsxr.GetAll() on a.IdNsx equals e.Id
                select new ChiTietSanPhamView()
                {
                    Id = a.Id,
                    IdMauSac = a.IdMauSac,
                    IdDongSp = a.IdDongSp,
                    IdNsx = a.IdNsx,
                    IdSp = a.IdSp,
                    NamBh = a.NamBh,
                    MoTa = a.MoTa,
                    SoLuongTon = a.SoLuongTon,
                    GiaNhap = a.GiaNhap,
                    GiaBan = a.GiaBan,
                    TenMauSac = c.Ten,
                    TenDongSanPham = d.Ten,
                    TenSanPham = b.Ten,
                    TenNhaSanXuat = e.Ten
                }
                ).ToList();
            return listctsp;
        }

        //public List<SanPhamView> GetAll()
        //{
        //    List<SanPhamView> listspv = new List<SanPhamView>();
        //    listspv = (
        //         from a in ctspr.GetAll()
        //         join b in spr.GetAll() on a.IdSp equals b.Id
        //         join c in nsxr.GetAll() on a.IdNsx equals c.Id
        //         join d in dspr.GetAll() on a.IdDongSp equals d.Id
        //         join e in mausacr.GetAll() on a.IdMauSac equals e.Id
        //         select new SanPhamView()
        //         {
        //             ChiTietSp = a,
        //             SanPham = b,
        //             Nsx = c,
        //             DongSp = d,
        //             MauSac = e
        //         }


        //        ).ToList();
        //    return listspv;
        //}

        public string UpdateCTSP(ChiTietSanPhamView ctspv)
        {
            if (ctspv == null) return "NOT";
            ChiTietSp thao = new ChiTietSp()
            {
                Id = ctspv.Id,
                IdSp = ctspv.IdSp,
                IdNsx = ctspv.IdNsx,
                IdDongSp = ctspv.IdDongSp,
                IdMauSac = ctspv.IdMauSac,
                NamBh = ctspv.NamBh,
                MoTa = ctspv.MoTa,
                SoLuongTon = ctspv.SoLuongTon,
                GiaNhap = ctspv.GiaNhap,
                GiaBan = ctspv.GiaBan,

            };
            if (ctspr.Update(thao)) return "OK";
            else return "NOT";
        }
        public string AddSP(SanPhamView spv)
        {
            if (spv == null) return "NOT";
            SanPham thao = new SanPham()
            {
                Ma = spv.Ma,
                Ten = spv.Ten
            };
            if (spr.Add(thao)) return "OK";
            else return "NOT";

        }
        public string UpdateSP(SanPhamView spv)
        {
            if (spv == null) return "NOT";
            SanPham thao = new SanPham()
            {
                Id = spv.Id,
                Ma = spv.Ma,
                Ten = spv.Ten
            };
            if (spr.Update(thao)) return "OK";
            else return "NOT";

        }
        public string DeleteSP(SanPhamView spv)
        {
            if (spv == null) return "NOT";
            SanPham thao = new SanPham()
            {
                Id = spv.Id
            };
            if (spr.Delete(thao)) return "OK";
            else return "NOT";

        }


        public List<SanPhamView> GetSP()
        {
            List<SanPhamView> listspv = new List<SanPhamView>();
            listspv = (
                 from a in spr.GetAll()
                 select new SanPhamView()
                 {
                     Id = a.Id,
                     Ma = a.Ma,
                     Ten = a.Ten
                 }

                ).ToList();

            return listspv;

        }
        public bool CheckMaSP(string cmasp)
        {
            var x = GetSP().FirstOrDefault(a => a.Ma == cmasp);
            if (x != null)
                return true;
            else return false;
        }

        public string AddDSP(DongSanPhamView dspv)
        {
            if (dspv == null) return "NOT";
            DongSp thao = new DongSp();
            thao.Ma = dspv.Ma;
            thao.Ten = dspv.Ten;
            if (dspr.Add(thao)) return "OK";
            else return "NOT";

        }
        public string UpdateDSP(DongSanPhamView dspv)
        {
            if (dspv == null) return "NOT";
            DongSp thao = new DongSp();
            thao.Id = dspv.Id;
            thao.Ma = dspv.Ma;
            thao.Ten = dspv.Ten;
            if (dspr.Update(thao)) return "OK";
            else return "NOT";

        }
        public string DeleteDSP(DongSanPhamView dspv)
        {
            if (dspv == null) return "NOT";
            DongSp thao = new DongSp();
            thao.Id = dspv.Id;

            if (dspr.Delete(thao)) return "OK";
            else return "NOT";

        }
        public List<DongSanPhamView> GetDSP()
        {
            List<DongSanPhamView> listspv = new List<DongSanPhamView>();
            listspv = (
                 from a in dspr.GetAll()
                 select new DongSanPhamView()
                 {
                     Id = a.Id,
                     Ma = a.Ma,
                     Ten = a.Ten
                 }

                ).ToList();
            return listspv;
        }
        public bool CheckDSP(string cmadsp)
        {
            var thao = GetDSP().FirstOrDefault(a => a.Ma == cmadsp);
            if (thao == null) return false;
            else return true;
        }

        public string AddNSX(NhaSanXuatView nsxv)
        {
            if (nsxv == null) return "NOT";
            Nsx thao = new Nsx()
            {

                Ma = nsxv.Ma,
                Ten = nsxv.Ten
            };
            if (nsxr.Add(thao)) return "OK";
            else return "NOT";
        }

        public string UpdateNSX(NhaSanXuatView nsxv)
        {
            if (nsxv == null) return "NOT";
            Nsx thao = new Nsx()
            {
                Id = nsxv.Id,
                Ma = nsxv.Ma,
                Ten = nsxv.Ten
            };
            if (nsxr.Update(thao)) return "OK";
            else return "NOT";
        }

        public string DeleteNSX(NhaSanXuatView nsxv)
        {
            if (nsxv == null) return "NOT";
            Nsx thao = new Nsx()
            {
                Id = nsxv.Id
            };

            if (nsxr.Delete(thao)) return "OK";
            else return "NOT";
        }

        public List<NhaSanXuatView> GetNSX()
        {

            List<NhaSanXuatView> listnsx = new List<NhaSanXuatView>();
            listnsx = (
                 from a in nsxr.GetAll()
                 select new NhaSanXuatView()
                 {
                     Id = a.Id,
                     Ma = a.Ma,
                     Ten = a.Ten
                 }

                ).ToList();

            return listnsx;
        }
        public bool CheckNSX(string cmansx)
        {
            var thao = GetNSX().FirstOrDefault(a => a.Ma == cmansx);
            if (thao == null) return false;
            else return true;
        }

        public string AddMS(MauSacView msv)
        {
            if (msv == null) return "NOT";
            MauSac violet = new MauSac()
            {
                Ma = msv.Ma,
                Ten = msv.Ten
            };
            if (mausacr.Add(violet)) return "OK";
            else return "NOT";
        }

        public string UpdateMS(MauSacView msv)
        {
            if (msv == null) return "NOT";
            MauSac violet = new MauSac()
            {
                Id = msv.Id,
                Ma = msv.Ma,
                Ten = msv.Ten
            };
            if (mausacr.Update(violet)) return "OK";
            else return "NOT";
        }

        public string DeleteMS(MauSacView msv)
        {
            if (msv == null) return "NOT";
            MauSac violet = new MauSac()
            {
                Id = msv.Id
            };
            if (mausacr.Delete(violet)) return "OK";
            else return "NOT";
        }

        public List<MauSacView> GetMauSac()
        {

            List<MauSacView> listms = new List<MauSacView>();
            listms = (
                 from a in mausacr.GetAll()
                 select new MauSacView()
                 {
                     Id = a.Id,
                     Ma = a.Ma,
                     Ten = a.Ten
                 }

                ).ToList();

            return listms;
        }
        public bool CheckMS(string cmams)
        {
            var thao = GetMauSac().FirstOrDefault(a => a.Ma == cmams);
            if (thao == null) return false;
            else return true;
        }

    }
}
