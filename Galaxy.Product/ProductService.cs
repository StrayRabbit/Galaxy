using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Galaxy.Product.Contracts;
using Galaxy.Product.Contracts.Models.Dtos;
using Volo.Abp.Application.Services;

namespace Galaxy.Product
{
    public class ProductService : ApplicationService, IProductService
    {
        public Task<ProductDto> CreateAsync(ProductDto product)
        {
            return Task.FromResult(new ProductDto());
        }

        public async Task<ProductDto> GetAsync(string id)
        {
            var task = await Task.Run(() => new ProductDto() { Id = id, Name = "product" });

            return task;
        }

        public async Task<List<ProductQueryDto>> GetListAsync()
        {
            return await Task.Run(() =>
            {
                return new List<ProductQueryDto>()
            {
                new ProductQueryDto(){Id = "1",Name = "orange"},
                new ProductQueryDto(){Id = "2",Name = "apple"}
            };
            });
        }
    }
}