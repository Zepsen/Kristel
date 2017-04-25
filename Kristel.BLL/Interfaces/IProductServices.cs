using Kristel.BLL.DTO;
using System.Collections.Generic;

namespace Kristel.BLL.Interfaces
{
    public interface IProductServices
    {
        IEnumerable<ProductDTO> GetProducts();
    }
}
