using Application.Services;
using Domain.Entities;
using Domain.Interfaces;
using Moq;

namespace Clean_Architecture_WebAPI.Test
{
    public class ProductServiceTests
    {
        [Fact]
        public async Task GetProductsAsync_ShouldReturnProducts()
        {
            var mockRepository = new Mock<IProductRepository>();
            mockRepository.Setup(repo => repo.GetProductsAsync()).ReturnsAsync(GetTestProducts());

            var productService = new ProductService(mockRepository.Object);
            var result = await productService.GetProductsAsync();

            Assert.Equal(3, result.Count());
        }

        private IEnumerable<Product> GetTestProducts()
        {
            return new List<Product>
        {
            new Product { Id = 1, Name = "Product1", Price = 10 },
            new Product { Id = 2, Name = "Product2", Price = 20 },
            new Product { Id = 3, Name = "Product3", Price = 30 }
        };
        }
    }
}
