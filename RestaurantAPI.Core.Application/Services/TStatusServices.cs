using AutoMapper;
using RestauranteAPI.Core.Application.Interfaces.Repository;
using RestauranteAPI.Core.Application.Interfaces.Services;
using RestauranteAPI.Core.Application.ViewModel.TStatus;
using RestauranteAPI.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Core.Application.Services
{
    public class TStatusServices : GenericServices<SaveTStatusViewModel, TStatusViewModel, TablesStatus>, ITStatusServices
    {
        private readonly ITStatusRepository _TStatusRepository;
        private IMapper _mapper;
        public TStatusServices(ITStatusRepository tStatusRepository, IMapper mapper) : base(tStatusRepository, mapper)
        {
            _TStatusRepository = tStatusRepository;
            _mapper = mapper;
        }
    }
}
