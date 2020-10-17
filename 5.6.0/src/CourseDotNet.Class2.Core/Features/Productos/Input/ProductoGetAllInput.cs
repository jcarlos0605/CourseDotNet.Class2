using Abp.Application.Services.Dto;

namespace CourseDotNet.Class2.Features.Productos.Input
{
    public class ProductoGetAllInput : IPagedResultRequest
    {
        public int SkipCount { get ; set ; }
        public int MaxResultCount { get ; set ; }
    }
}
