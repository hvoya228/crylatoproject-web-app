using AutoMapper;
using Phrases.Data.Dtos;
using Phrases.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phrases.BLL.Profiles
{
    public class PhraseProfile : Profile
    {
        public PhraseProfile() 
        { 
            CreateMap<Phrase, PhraseDto>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.PhraseName, opt => opt.MapFrom(src => src.PhraseName))
                .ForMember(dest => dest.PhraseDescription, opt => opt.MapFrom(src => src.PhraseDescription))
                .ForMember(dest => dest.PhraseLikes, opt => opt.MapFrom(src => src.PhraseLikes));
        }
    }
}
