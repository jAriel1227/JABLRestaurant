using AutoMapper;
using RestauranteAPI.Core.Application.Interfaces.Repository;
using RestauranteAPI.Core.Application.Interfaces.Services;
using RestauranteAPI.Core.Application.ViewModel.Tables;
using RestauranteAPI.Core.Domain.Entities;

namespace RestauranteAPI.Core.Application.Services
{
    public class TablesServices : GenericServices<SaveTablesViewModel, TablesViewModel, Tables>, ITablesServices
    {
        private readonly ITablesRepository _tablesRepository;
        private readonly IMapper _mapper;

        public TablesServices(ITablesRepository tablesRepository, IMapper mapper) : base(tablesRepository, mapper)
        {
            _tablesRepository = tablesRepository;
            _mapper = mapper;
        }
    }
}
