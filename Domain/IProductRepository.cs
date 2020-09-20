using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        void SaveProductData(ProductsData data);
        ProductsData GetProductsData(int productId);
    }
}
