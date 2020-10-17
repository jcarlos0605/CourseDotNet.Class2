﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDotNet.Class2.Features.Productos.Dto
{
    public class ProductoDto : EntityDto
    {
        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        public int Existencia { get; set; }

        public decimal Precio { get; set; }
    }
}
