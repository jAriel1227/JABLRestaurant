using RestauranteAPI.Core.Application.ViewModel.Ingredients;
using RestauranteAPI.Core.Domain.Entities;

namespace RestauranteAPI.Core.Application.Interfaces.Services
{
    public interface IIngredientsServices : IGenericServices<SaveIngredientsViewModel, IngredientsViewModel, Ingredients>
    {

    }
}
