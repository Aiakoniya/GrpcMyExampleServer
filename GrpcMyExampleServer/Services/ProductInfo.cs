using GrpcMyExampleServer.Protos;
namespace GrpcMyExampleServer.Services
{
    internal class ProductInfo
    {
        public UserInfo User { get; internal set; }
        public string Price { get; internal set; }
    }
}