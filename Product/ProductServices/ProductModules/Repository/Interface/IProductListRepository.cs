using System;
using System.Collections.Generic;
using ProductModules.Domain;


namespace ProductModules.Repository.Interface
{
    public interface IProductListRepository
    {
        IEnumerable<Product> GetPagedItem(int pageNo, int count);
    }
}
