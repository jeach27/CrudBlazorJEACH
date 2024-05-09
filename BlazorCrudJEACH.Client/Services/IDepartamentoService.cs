using BlazorCrudJEACH.Shared;

namespace BlazorCrudJEACH.Client.Services
{
    public interface IDepartamentoService
    {
        Task<List<DepartamentoDTO>> Lista();
    }
}
