using AutoMapper;
using RestauranteAPI.Core.Application.Interfaces.Repository;
using RestauranteAPI.Core.Application.Interfaces.Services;
using RestauranteAPI.Core.Application.ViewModel.Plates;
using RestauranteAPI.Core.Domain.Entities;

namespace RestauranteAPI.Core.Application.Services
{
    public class PlatesServices : GenericServices<SavePlatesViewModel, PlatesViewModel, Plates>, IPlatesServices
    {
        private readonly IPlatesRepository _iPlatesRepository;
        private readonly IMapper _mapper;

        public PlatesServices(IPlatesRepository iPlatesRepository, IMapper mapper) : base(iPlatesRepository, mapper)
        {
            _iPlatesRepository = iPlatesRepository;
            _mapper = mapper;
        }
    }
}
