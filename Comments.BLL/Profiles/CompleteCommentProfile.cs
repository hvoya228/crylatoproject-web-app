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
    public class CompleteCommentProfile : Profile
    {
        public CompleteCommentProfile() 
        {
            CreateMap<CompleteComment, CompleteCommentDto>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.CommentTheme, opt => opt.MapFrom(src => src.CommentTheme))
                .ForMember(dest => dest.CommentText, opt => opt.MapFrom(src => src.CommentText))
                .ForMember(dest => dest.CommentPostDate, opt => opt.MapFrom(src => src.CommentPostDate))
                .ForMember(dest => dest.FeedbackTheme, opt => opt.MapFrom(src => src.FeedbackTheme));
        }
    }
}
