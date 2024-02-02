using AutoMapper;
using DataAcesss.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<HotelRoomDTO, HotelRoom>();
            CreateMap<HotelRoom, HotelRoomDTO>();
            CreateMap<HotelAmenity, HotelAmenityDTO>().ReverseMap();
            CreateMap<HotelRoomImage, HotelRoomImageDTO>().ReverseMap();
            CreateMap<RoomOrderDetails, RoomOrderDetailsDTO>().ForMember(x => x.HotelRoomDTO, opt => opt.MapFrom(c => c.HotelRoom));
            CreateMap<RoomOrderDetailsDTO, RoomOrderDetails>();

            CreateMap<SiteDTO, Site>();
            CreateMap<Site, SiteDTO>();
            CreateMap<Company, CompanyDTO>();
            CreateMap<CompanyDTO, Company>();
            CreateMap<FactoryDetails, FactoryDetailsDTO>();
            CreateMap<FactoryDetailsDTO, FactoryDetails>();
            CreateMap<AcceptanceCriteria, AcceptanceCriteriaDTO>();
            CreateMap<AcceptanceCriteriaDTO, AcceptanceCriteria>();
            CreateMap<DefectType, DefectTypeDTO>();
            CreateMap<DefectTypeDTO, DefectType>();
            CreateMap<CompanySoftware, CompanySoftwareDTO>();
            CreateMap<CompanySoftwareDTO, CompanySoftware>();
            CreateMap<CriteriaBasket, CriteriaBasketDTO>();
            CreateMap<CriteriaBasketDTO, CriteriaBasket>();
            CreateMap<ImageProcessReq, ImageProcessReqDTO>();
            CreateMap<ImageProcessReqDTO, ImageProcessReq>();
            CreateMap<Manufacturer, ManufacturerDTO>();
            CreateMap<ManufacturerDTO, ManufacturerDTO>();
            CreateMap<ProjectDetails, ProjectDetailsDTO>();
            CreateMap<ProjectDetailsDTO, ProjectDetails>();
            CreateMap<TextInImage, TextInImageDTO>();
            CreateMap<TextInImageDTO, TextInImage>();

        }
    }
}
