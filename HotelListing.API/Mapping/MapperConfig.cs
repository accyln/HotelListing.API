using AutoMapper;
using HotelListing.API.Models;

namespace HotelListing.API.Mapping
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<TestSuiteAddDto, TestSuite>();
            CreateMap<TestSuite, TestSuiteAddDto>();

            CreateMap<GetTestSuiteDto, TestSuite>();
            CreateMap<TestSuite, GetTestSuiteDto>();
        }
    }
}
