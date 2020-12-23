using System;
using System.Threading;
using System.Threading.Tasks;
using Galaxy.Order.Contracts;
using Galaxy.Order.Contracts.Models.Dtos;
using Galaxy.Product.Contracts;
using Volo.Abp.Application.Services;

namespace Galaxy.Order
{
    public class OrderService : ApplicationService, IOrderService
    {
        private IProductService productService { get; set; }

        public OrderService(IProductService productService)
        {
            this.productService = productService;
        }
        public Task<OrderDto> CreateAsync(OrderDto order)
        {
            return Task.FromResult(new OrderDto());
        }

        public async Task<OrderDto> GetAsync(string id)
        {
            var items = await this.productService.GetListAsync();
            var task = await Task.Run(() =>
            {
                Thread.Sleep(100);
                return new OrderDto() { Id = id, OrderNo = "orderNo", ProductItems = items };
            });

            return task;
        }
    }
}