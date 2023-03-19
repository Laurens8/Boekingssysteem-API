using AutoMapper;
using Boekingssysteem.Models;
using Boekingssysteem_API.Data.Dto;

namespace Boekingssysteem_API.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Persoon, PersoonDto>();
            CreateMap<PersoonDto, Persoon>();
        }
    }
}
