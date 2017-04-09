using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreWeb.Responses;

namespace StoreWeb.Repository.Interface
{
    public interface IProductService
    {
        IEnumerable<ProductListResponse> GetProductListOnPage(int pageNo);

        ProductDetailResponse GetProductDetail(int productId);

    }
}
