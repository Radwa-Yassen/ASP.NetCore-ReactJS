using ChemiClean.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public interface IProductService
    {
        List<ProductView> GetProducts();
    }
}
