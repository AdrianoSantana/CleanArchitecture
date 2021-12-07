using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchMVC.Application.DTOs;
using CleanArchMVC.Application.Interfaces;
using CleanArchMVC.Domain.Entities;
using CleanArchMVC.Domain.Interfaces;

namespace CleanArchMVC.Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(
            IProductRepository productRepository,
            IMapper mapper
        )
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }
        public async Task Add(ProductDTO ProductdTO)
        {
            var productEntity = _mapper.Map<Product>(ProductdTO);
            await _productRepository.CreateProductAsync(productEntity);
        }

        public async Task<ProductDTO> GetById(int? id)
        {
            var productEntity = await _productRepository.GetByIdAsync(id);
            return _mapper.Map<ProductDTO>(productEntity);
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var productsEntities = await _productRepository.GetProducts();
            return _mapper.Map<IEnumerable<ProductDTO>>(productsEntities);
        }

        public async Task Remove(int? id)
        {
            var productEntity = await _productRepository.GetByIdAsync(id);
            await _productRepository.RemoveProductAsync(productEntity);
        }

        public async Task Update(ProductDTO ProductdTO)
        {
            var productEntity = _mapper.Map<Product>(ProductdTO);
            await _productRepository.UpdateProductAsync(productEntity);
        }
    }
}