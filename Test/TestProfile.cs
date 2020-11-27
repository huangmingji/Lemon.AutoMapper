using AutoMapper;

namespace Test
{
    public class TestProfile : Profile
    {
        public TestProfile() 
        {
            CreateMap<Source, Destination>();
        }
    }
}