using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchMVC.Application.DTOs;
using CleanArchMVC.Application.Interfaces;
using CleanArchMVC.Domain.Entities;
using CleanArchMVC.Domain.Interfaces;

namespace CleanArchMVC.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(
            ICategoryRepository categoryRepository,
            IMapper mapper
        )
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }
        public async Task Add(CategoryDTO categoryDTO)
        {
            var categoryEntity = _mapper.Map<Category>(categoryDTO);
            await _categoryRepository.CreateCategoryAsync(categoryEntity);
        }

        public async Task<CategoryDTO> GetById(int? id)
        {
            var categoriesEntity = await _categoryRepository.GetByIdAsync(id);
            return _mapper.Map<CategoryDTO>(categoriesEntity);
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategories()
        {
            var categoriesEntity = await _categoryRepository.GetCategoriesAsync();
            return _mapper.Map<IEnumerable<CategoryDTO>>(categoriesEntity);
        }

        public async Task Remove(int? id)
        {
            var categoryEntity = await _categoryRepository.GetByIdAsync(id);
            await _categoryRepository.RemoveCategoryAsync(categoryEntity);
        }

        public async Task Update(CategoryDTO categoryDTO)
        {
            var categoryEntity = _mapper.Map<Category>(categoryDTO);
            await _categoryRepository.UpdateCategoryAsync(categoryEntity);
        }
    }
}