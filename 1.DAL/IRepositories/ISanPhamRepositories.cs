﻿using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ISanPhamRepositories
    {
        bool Add(SanPham sp);
        bool Update(SanPham sp);
        bool Delete(SanPham sp);
       List<SanPham> GetAll();
    }
}
