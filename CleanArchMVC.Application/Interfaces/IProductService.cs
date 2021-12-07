using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArchMVC.Application.DTOs;

namespace CleanArchMVC.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProducts();

        Task<ProductDTO> GetById(int? id);

        Task Add(ProductDTO ProductdTO);

        Task Update(ProductDTO ProductdTO);

        Task Remove(int? id);
    }
}