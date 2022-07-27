
using AutoMapper;
using RestauranteAPI.Core.Application.Interfaces.Repository;
using RestauranteAPI.Core.Application.Interfaces.Services;
using RestauranteAPI.Core.Application.ViewModel.PCategory;
using RestauranteAPI.Core.Domain.Entities;


namespace RestauranteAPI.Core.Application.Services
{
    public class PCategoryServices : GenericServices<SavePCategoryViewModel, PCategoryViewModel, PlatesCategory>, IPCategoryServices
    {
        private readonly IPCategoryRepository _iPCategoryRepository;
        private readonly IMapper _mapper;

        public PCategoryServices(IPCategoryRepository iPCategoryRepository, IMapper mapper) : base(iPCategoryRepository, mapper)
        {
            _iPCategoryRepository = iPCategoryRepository;
            _mapper = mapper;
        }
    }
}
