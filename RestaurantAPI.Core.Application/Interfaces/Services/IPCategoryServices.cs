using RestauranteAPI.Core.Application.ViewModel.PCategory;
using RestauranteAPI.Core.Domain.Entities;

namespace RestauranteAPI.Core.Application.Interfaces.Services
{
    public interface IPCategoryServices : IGenericServices<SavePCategoryViewModel, PCategoryViewModel, PlatesCategory>
    {

    }
}
