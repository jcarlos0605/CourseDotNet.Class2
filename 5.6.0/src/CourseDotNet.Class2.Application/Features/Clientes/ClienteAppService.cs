using Abp.Application.Services;
using Abp.Domain.Repositories;
using CourseDotNet.Class2.Features.Clientes.Dto;
using CourseDotNet.Class2.Features.Clientes.Input;

namespace CourseDotNet.Class2.Features.Clientes
{
    public class ClienteAppService : AsyncCrudAppService<Cliente,ClienteDto,int
        ,ClienteGetAllInput,ClienteCreateInput,ClienteUpdateInput,ClienteGetInput,ClienteDeleteInput>,IClienteAppService
    {
        public ClienteAppService(IRepository<Cliente> repository) : base(repository)
        {

        }

    }
                
         
}
