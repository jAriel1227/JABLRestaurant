using AutoMapper;
using RestauranteAPI.Core.Application.DTOS.Account;
using RestauranteAPI.Core.Application.ViewModel.Ingredients;
using RestauranteAPI.Core.Application.ViewModel.Orders;
using RestauranteAPI.Core.Application.ViewModel.OStatus;
using RestauranteAPI.Core.Application.ViewModel.PCategory;
using RestauranteAPI.Core.Application.ViewModel.Plates;
using RestauranteAPI.Core.Application.ViewModel.Tables;
using RestauranteAPI.Core.Application.ViewModel.TStatus;
using RestauranteAPI.Core.Application.ViewModel.User;
using RestauranteAPI.Core.Domain.Entities;

namespace RestaurantAPI.Core.Application.Mapping
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<AuthenticationRequest, LoginViewModel>()
                .ForMember(x => x.HasError, opt => opt.Ignore())
                .ForMember(x => x.Error, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<RegisterRequest, SaveUserViewModel>()
                .ForMember(x => x.UserType, opt => opt.Ignore())
                .ForMember(x => x.HasError, opt => opt.Ignore())
                .ForMember(x => x.Error, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<AccountResponse, UserViewModel>()
                .ForMember(x => x.Roles, opt => opt.MapFrom(ac => ac.Roles))
                .ReverseMap();

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

            CreateMap<Oders, OrdersViewModel>()
                    .ReverseMap()
                    .ForMember(x => x.OdersStatus, opt => opt.Ignore())
                    .ForMember(x => x.Created, opt => opt.Ignore())
                    .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                    .ForMember(x => x.Modified, opt => opt.Ignore())
                    .ForMember(x => x.ModifiedBy, opt => opt.Ignore());

            CreateMap<Oders, SaveOrdersViewModel>()
                   .ReverseMap()
                   .ForMember(x => x.OdersStatus, opt => opt.Ignore())
                   .ForMember(x => x.Created, opt => opt.Ignore())
                   .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                   .ForMember(x => x.Modified, opt => opt.Ignore())
                   .ForMember(x => x.ModifiedBy, opt => opt.Ignore());

            CreateMap<OdersStatus, OStatusViewModel>()
                    .ReverseMap()                    
                    .ForMember(x => x.Created, opt => opt.Ignore())
                    .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                    .ForMember(x => x.Modified, opt => opt.Ignore())
                    .ForMember(x => x.ModifiedBy, opt => opt.Ignore());

            CreateMap<OdersStatus, SaveOStatusViewModel>()
                   .ReverseMap()                   
                   .ForMember(x => x.Created, opt => opt.Ignore())
                   .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                   .ForMember(x => x.Modified, opt => opt.Ignore())
                   .ForMember(x => x.ModifiedBy, opt => opt.Ignore());

            CreateMap<PlatesCategory, PCategoryViewModel>()
                    .ReverseMap()
                    .ForMember(x => x.Created, opt => opt.Ignore())
                    .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                    .ForMember(x => x.Modified, opt => opt.Ignore())
                    .ForMember(x => x.ModifiedBy, opt => opt.Ignore());

            CreateMap<PlatesCategory, SavePCategoryViewModel>()
                   .ReverseMap()
                   .ForMember(x => x.Created, opt => opt.Ignore())
                   .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                   .ForMember(x => x.Modified, opt => opt.Ignore())
                   .ForMember(x => x.ModifiedBy, opt => opt.Ignore());

            CreateMap<Plates, PlatesViewModel>()
                    .ReverseMap()
                    .ForMember(x => x.PlatesIngredients, opt => opt.Ignore())
                    .ForMember(x => x.PlatesCategory, opt => opt.Ignore())
                    .ForMember(x => x.Oders, opt => opt.Ignore())
                    .ForMember(x => x.Created, opt => opt.Ignore())
                    .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                    .ForMember(x => x.Modified, opt => opt.Ignore())
                    .ForMember(x => x.ModifiedBy, opt => opt.Ignore());

            CreateMap<Plates, SavePlatesViewModel>()
                   .ReverseMap()
                   .ForMember(x => x.PlatesIngredients, opt => opt.Ignore())
                   .ForMember(x => x.PlatesCategory, opt => opt.Ignore())
                   .ForMember(x => x.Oders, opt => opt.Ignore())
                   .ForMember(x => x.Created, opt => opt.Ignore())
                   .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                   .ForMember(x => x.Modified, opt => opt.Ignore())
                   .ForMember(x => x.ModifiedBy, opt => opt.Ignore());

            CreateMap<Tables, TablesViewModel>()
                    .ReverseMap()
                    .ForMember(x => x.TablesStatus, opt => opt.Ignore())
                    .ForMember(x => x.Created, opt => opt.Ignore())
                    .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                    .ForMember(x => x.Modified, opt => opt.Ignore())
                    .ForMember(x => x.ModifiedBy, opt => opt.Ignore());

            CreateMap<Tables, SaveTablesViewModel>()
                   .ReverseMap()
                   .ForMember(x => x.TablesStatus, opt => opt.Ignore())
                   .ForMember(x => x.Created, opt => opt.Ignore())
                   .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                   .ForMember(x => x.Modified, opt => opt.Ignore())
                   .ForMember(x => x.ModifiedBy, opt => opt.Ignore());

            CreateMap<TablesStatus, TStatusViewModel>()
                    .ReverseMap()                    
                    .ForMember(x => x.Created, opt => opt.Ignore())
                    .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                    .ForMember(x => x.Modified, opt => opt.Ignore())
                    .ForMember(x => x.ModifiedBy, opt => opt.Ignore());

            CreateMap<TablesStatus, SaveTStatusViewModel>()
                   .ReverseMap()                   
                   .ForMember(x => x.Created, opt => opt.Ignore())
                   .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                   .ForMember(x => x.Modified, opt => opt.Ignore())
                   .ForMember(x => x.ModifiedBy, opt => opt.Ignore());

            CreateMap<ActivateRequest, ActivateViewModel>()
                .ReverseMap();

            CreateMap<EditRequest, SaveEditViewModel>()
                .ForMember(x => x.UserType, opt => opt.Ignore())
                .ForMember(x => x.Amount, opt => opt.Ignore())
                .ReverseMap();
        }       
    }
}
