﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDotNet.Class2.Features.Clientes.Input
{
    public class ClienteGetAllInput : IPagedResultRequest
    {
        public int SkipCount { get; set; }
        public int MaxResultCount { get; set; }

    }

}