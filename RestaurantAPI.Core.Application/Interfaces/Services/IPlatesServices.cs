using RestauranteAPI.Core.Application.ViewModel.Plates;
using RestauranteAPI.Core.Domain.Entities;

namespace RestauranteAPI.Core.Application.Interfaces.Services
{
    public interface IPlatesServices : IGenericServices<SavePlatesViewModel, PlatesViewModel, Plates>
    {

    }
}
