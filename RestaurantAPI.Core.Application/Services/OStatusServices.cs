using AutoMapper;
using RestauranteAPI.Core.Application.Interfaces.Repository;
using RestauranteAPI.Core.Application.Interfaces.Services;
using RestauranteAPI.Core.Application.ViewModel.OStatus;
using RestauranteAPI.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Core.Application.Services
{
    public class OStatusServices : GenericServices<SaveOStatusViewModel, OStatusViewModel, OdersStatus>, IOStatusServices
    {
        private readonly IOStatusRepository _oStatusRepository;
        private readonly IMapper _mapper;

        public OStatusServices(IOStatusRepository oStatusRepository, IMapper mapper) : base(oStatusRepository, mapper)
        {
            _oStatusRepository = oStatusRepository;
            _mapper = mapper;
        }
    }
}
