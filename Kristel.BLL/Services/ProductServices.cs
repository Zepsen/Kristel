using System;
using System.Collections.Generic;
using Kristel.BLL.DTO;
using Kristel.BLL.Interfaces;
using Kristel.DAL.Interfaces;
using System.Linq;

namespace Kristel.BLL.Services
{
    public class ProductServices : IProductServices
    {
        private IUnitOfWork _db { get; set; }

        public ProductServices(IUnitOfWork uow)
        {
            _db = uow;
        }

        public IEnumerable<ProductDTO> GetProducts()
        {
            var products = _db.Products.GetAll();
            return products.Select(ProductDTO.Map).ToList();
        }
    }
}
