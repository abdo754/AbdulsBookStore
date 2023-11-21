using AbdulsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbdulsBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType> 
    {
        void Update(CoverType covertype); 
    }
}

