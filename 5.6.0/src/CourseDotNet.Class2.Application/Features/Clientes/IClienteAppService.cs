using Abp.Application.Services;
using CourseDotNet.Class2.Features.Clientes.Dto;
using CourseDotNet.Class2.Features.Clientes.Input;

namespace CourseDotNet.Class2.Features.Clientes
{
    public interface IClienteAppService : IAsyncCrudAppService<ClienteDto, int, ClienteGetAllInput
        , ClienteCreateInput, ClienteUpdateInput, ClienteGetInput, ClienteDeleteInput>
    {

    }
}