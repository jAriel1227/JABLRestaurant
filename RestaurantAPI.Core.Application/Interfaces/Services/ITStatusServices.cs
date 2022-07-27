using RestauranteAPI.Core.Application.ViewModel.TStatus;
using RestauranteAPI.Core.Domain.Entities;

namespace RestauranteAPI.Core.Application.Interfaces.Services
{
    public interface ITStatusServices : IGenericServices<SaveTStatusViewModel, TStatusViewModel, TablesStatus>
    {

    }
}
