﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestauranteAPI.Core.Application.Interfaces.Services
{
    public interface IGenericServices<SaveViewModel, ViewModel, Entity>
        where SaveViewModel : class
        where ViewModel : class
        where Entity : class
    {
        Task Update(SaveViewModel vm, int Id);

        Task<SaveViewModel> Add(SaveViewModel vm);

        Task Delete(int id);

        Task<SaveViewModel> GetByIdSaveViewModel(int id);

        Task<List<ViewModel>> GetAllViewModel();
    }
}
