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
    internal class CommentDtoProfile : Profile
    {
        public CommentDtoProfile()
        {
            CreateMap<CommentDto, Comment>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.CommentTheme, opt => opt.MapFrom(src => src.CommentTheme))
                .ForMember(dest => dest.CommentText, opt => opt.MapFrom(src => src.CommentText))
                .ForMember(dest => dest.CommentPostDate, opt => opt.MapFrom(src => src.CommentPostDate))
                .ForMember(dest => dest.CommentFeedbackId, opt => opt.MapFrom(src => src.CommentFeedbackId));
        }
    }
}
