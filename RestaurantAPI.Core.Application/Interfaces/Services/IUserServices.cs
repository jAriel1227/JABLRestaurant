using RestauranteAPI.Core.Application.DTOS.Account;
using RestauranteAPI.Core.Application.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Core.Application.Interfaces.Services
{
    public interface IUserServices
    {
        Task<AuthenticationResponse> LoginAsync(LoginViewModel model);        
        Task<RegisterResponse> RegisterAdministratorAsync(SaveUserViewModel model);
        Task<ActivateResponse> ActivateAsync(ActivateViewModel model);
        Task<ActivateResponse> DeactivateAsync(ActivateViewModel model);
        Task LogOutAsync();
        Task<List<UserViewModel>> GetAllUserAsync();
        Task<PasswordResponse> ChangePasswordAsync(PasswordRequest password);
        Task<EditResponse> EditUserAsync(SaveEditViewModel vm);

    }
}
