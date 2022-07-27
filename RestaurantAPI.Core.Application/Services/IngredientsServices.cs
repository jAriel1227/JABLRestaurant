using AutoMapper;
using RestauranteAPI.Core.Application.Interfaces.Repository;
using RestauranteAPI.Core.Application.Interfaces.Services;
using RestauranteAPI.Core.Application.ViewModel.Ingredients;
using RestauranteAPI.Core.Domain.Entities;

namespace RestauranteAPI.Core.Application.Services
{
    public class IngredientsServices : GenericServices<SaveIngredientsViewModel,IngredientsViewModel, Ingredients>, IIngredientsServices
    {
        private readonly IIngredientsRepository _igredientsRepository;
        private IMapper _mapper;
        public IngredientsServices(IIngredientsRepository igredientsRepository, IMapper mapper) : base(igredientsRepository, mapper)
        {
            _igredientsRepository = igredientsRepository;
            _mapper = mapper;
        }
    }
}
