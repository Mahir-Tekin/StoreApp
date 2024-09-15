using SQLitePCL;
using StoreApp.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Data.Concrete
{
    public class EFStoreRepository : IStoreRepository
    {
        StoreAppDbContext _db;
        public EFStoreRepository(StoreAppDbContext db)
        {
            _db = db;
        }
        public IQueryable<Product> products => throw new NotImplementedException();

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
