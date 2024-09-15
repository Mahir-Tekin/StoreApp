using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Data.Concrete;

namespace StoreApp.Data.Abstract
{
    public interface IStoreRepository
    {
        IQueryable<Product> products { get; }
        void AddProduct(Product product);
    }
}
