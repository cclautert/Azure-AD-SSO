using AutoMapper;
using AzureAD.Core.Entities;
using AzureAD.Core.Models;

namespace AzureAD.Web
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreditCard, CreditCardModel>();
            CreateMap<CreditCardModel, CreditCard>();
            // Add other mappings as needed

            CreateMap<UserIncome, UserIncomeModel>().ReverseMap();
            CreateMap<UserBudget, UserBudgetModel>().ReverseMap();
            CreateMap<FamilyMemberRequest, FamilyMemberRequestModel>().ReverseMap();
        }
    }

}
