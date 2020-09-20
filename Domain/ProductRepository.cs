using Domain;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure
{
    public class ProductRepository: IProductRepository
    {
        DBContext _dbContext;

        public ProductRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }

        public void SaveProductData(ProductsData data)
        {
            _dbContext.ProductsData.Add(data);
            _dbContext.SaveChanges();
        }

        public ProductsData GetProductsData(int productId)
        {
            return _dbContext.ProductsData.Where(p => p.ProductId == productId).OrderByDescending(p => p.SavingDate).FirstOrDefault();
        }

    }
}
