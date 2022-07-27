using AutoMapper;
using RestaurantAPI.Core.Application.DTOS.Account;
using RestauranteAPI.Core.Application.ViewModel.Ingredients;
using RestauranteAPI.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI.Core.Application.Mapping
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Ingredients, IngredientsViewModel>()
                    .ReverseMap()
                    .ForMember(x => x.Plates, opt => opt.Ignore())
                    .ForMember(x => x.Created, opt => opt.Ignore())
                    .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                    .ForMember(x => x.Modified, opt => opt.Ignore())
                    .ForMember(x => x.ModifiedBy, opt => opt.Ignore());

            CreateMap<Ingredients, SaveIngredientsViewModel>()
                   .ReverseMap()
                   .ForMember(x => x.Plates, opt=> opt.Ignore())
                   .ForMember(x => x.Created, opt => opt.Ignore())
                   .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                   .ForMember(x => x.Modified, opt => opt.Ignore())
                   .ForMember(x => x.ModifiedBy, opt => opt.Ignore());
        }       
    }
}
