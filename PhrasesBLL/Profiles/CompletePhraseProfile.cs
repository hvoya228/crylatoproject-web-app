using AutoMapper;
using Phrases.Data.Dtos;
using Phrases.Data.Models;
using Phrases.Data.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phrases.BLL.Profiles
{
    public class CompletePhraseProfile : Profile
    {
        public CompletePhraseProfile() 
        {
            CreateMap<CompletePhrase, CompletePhraseDto>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.PhraseName, opt => opt.MapFrom(src => src.PhraseName))
                .ForMember(dest => dest.PhraseDescription, opt => opt.MapFrom(src => src.PhraseDescription))
                .ForMember(dest => dest.PhraseLikes, opt => opt.MapFrom(src => src.PhraseLikes))
                .ForMember(dest => dest.TagName, opt => opt.MapFrom(src => src.TagName))
                .ForMember(dest => dest.RegionName, opt => opt.MapFrom(src => src.RegionName));
        }
    }
}
