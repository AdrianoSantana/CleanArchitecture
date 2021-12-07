using System.ComponentModel;
using CleanArchMVC.Domain.Entities;

namespace CleanArchMVC.Application.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public Category Category { get; set; }
        
        [DisplayName("Categories")]
        public int CategoryId { get; set; }
    }
}