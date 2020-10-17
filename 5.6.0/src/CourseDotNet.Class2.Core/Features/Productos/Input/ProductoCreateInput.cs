using Abp.Application.Services.Dto;
using Abp.Domain.Entities;


namespace CourseDotNet.Class2.Features.Productos.Input
{
     public class ProductoCreateInput :EntityDto
    {
        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        public int Existencia { get; set; }

        public decimal Precio { get; set; }

     

    }
}
