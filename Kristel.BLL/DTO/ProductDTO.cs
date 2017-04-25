using Kristel.BLL.Interfaces;
using Kristel.DAL.Enities;
using System;

namespace Kristel.BLL.DTO
{
    public class ProductDTO 
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public static ProductDTO Map(Product product)
        {
            return new ProductDTO
            {
                Id = product.Id,
                Title = product.Title,
                Description = product.Description
            };
        }

       
    }
}
