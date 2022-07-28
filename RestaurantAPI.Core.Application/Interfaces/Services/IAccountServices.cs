﻿using RestauranteAPI.Core.Application.DTOS.Account;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestauranteAPI.Core.Application.Interfaces.Services
{
    public interface IAccountServices
    {
        Task<ActivateResponse> ActivateAsync(ActivateRequest request);
        Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request);
        Task<ActivateResponse> DeactivateAsync(ActivateRequest request);
        Task LogOutAsync();
        Task<RegisterResponse> RegisterAdministratorAsync(RegisterRequest request);        
        Task<List<AccountResponse>> GetUsersAsync();
        Task<PasswordResponse> ChangePasswordAsync(PasswordRequest request);
        Task<EditResponse> EditAccountAsync(EditRequest request);
    }
}