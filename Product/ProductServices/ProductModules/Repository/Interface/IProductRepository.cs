using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductModules.Domain;

namespace ProductModules.Repository.Interface
{
    public interface IProductRepository
    {
        Product GetProductDetail(int productId);
    }
}
