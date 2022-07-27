using RestauranteAPI.Core.Application.ViewModel.OStatus;
using RestauranteAPI.Core.Domain.Entities;

namespace RestauranteAPI.Core.Application.Interfaces.Services
{
     public interface IOStatusServices : IGenericServices<SaveOStatusViewModel, OStatusViewModel, OdersStatus>
     {

     }
}
