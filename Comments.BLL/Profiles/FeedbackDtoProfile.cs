using AutoMapper;
using Comments.Data.Dtos;
using Comments.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.BLL.Profiles
{
    public class FeedbackDtoProfile : Profile
    {
        public FeedbackDtoProfile()
        {
            CreateMap<FeedbackDto, Feedback>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.FeedbackTheme, opt => opt.MapFrom(src => src.FeedbackTheme));
        }
    }
}
