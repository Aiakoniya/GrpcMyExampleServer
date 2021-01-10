using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcMyExampleServer.Services
{
    public class ProductService : Product.ProductBase
    {
        private readonly ILogger<ProductService> _logger;
        private readonly List<ProductInfo> products = new List<ProductInfo>
        {
            new ProductInfo{User = new UserInfo { Id =  1, ProductName = "Chees Game", ParentCategoryId = 1}, Price = "$45" },
            new ProductInfo{ User = new UserInfo{Id = 2, ProductName = "Checker Game", ParentCategoryId = 2}, Price = "$78" },
            new ProductInfo{ User = new UserInfo{ Id = 3, ProductName = "Test Center", ParentCategoryId = 3}, Price = "$46" },
            new ProductInfo{User = new UserInfo{Id = 4, ProductName = "Proctoring Syste", ParentCategoryId = 4}, Price = "$100"}
        };

        public ProductService(ILogger<ProductService> logger)
        {
            _logger = logger;
        }

        public override Task<ProductInfo> GetProduct(ProductLookup request, ServerCallContext context)
        {
            var product = products.Where(x => x.User.Id == request.Id).FirstOrDefault();
            return Task.FromResult(product);
        }

        public override async Task GetAllProducts(AllProductsLookup request,
            IServerStreamWriter<ProductInfo> responseStream,
            ServerCallContext context)
        {
            foreach (var product in products)
            {
                await Task.Delay(1000);
                await responseStream.WriteAsync(product);
            }
        }
    }
}
