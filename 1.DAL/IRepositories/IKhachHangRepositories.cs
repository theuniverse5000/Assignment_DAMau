using _1.DAL.DomainClass;

namespace _1.DAL.IRepositories
{
    public interface IKhachHangRepositories
    {
        bool Add(KhachHang kh);

        bool Update(KhachHang khd);
        bool Delete(KhachHang kh);
        List<KhachHang> GetAll();

    }
}
