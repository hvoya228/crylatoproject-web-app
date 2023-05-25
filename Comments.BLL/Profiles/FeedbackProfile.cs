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
    public class FeedbackProfile : Profile
    {
        public FeedbackProfile() 
        {
            CreateMap<Feedback, FeedbackDto>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.FeedbackTheme, opt => opt.MapFrom(src => src.FeedbackTheme));
        }
    }
}
