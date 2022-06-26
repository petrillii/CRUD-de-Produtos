using AutoMapper;
using LojaJet.Models.Dto;
using LojaJet.Models.Entities;

namespace SquadHealthCheck.BLL.AutoMapping
{
    public class AutoMappingBLL : Profile
    {
        public AutoMappingBLL()
        {
            CreateMap<ProductEntity, ProductDto>().ReverseMap();
        }
        
    }
}
