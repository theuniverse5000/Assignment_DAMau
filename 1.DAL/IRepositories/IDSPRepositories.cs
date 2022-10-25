using _1.DAL.DomainClass;

namespace _1.DAL.IRepositories
{
    public interface IDSPRepositories
    {
        bool Add(DongSp dsp);
        bool Update(DongSp dspv);
        bool Delete(DongSp dsp);
        List<DongSp> GetAll();
        ///bool Add(string ma,string ten);
        //bool Update(Guid id, string ma, string ten);
        //bool Delete(Guid id);
        //List<DongSp> GetAll();
    }
}
