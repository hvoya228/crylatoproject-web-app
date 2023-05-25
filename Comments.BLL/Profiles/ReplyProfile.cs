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
    public class ReplyProfile : Profile
    {
        public ReplyProfile() 
        {
            CreateMap<Reply, ReplyDto>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.ReplyText, opt => opt.MapFrom(src => src.ReplyText))
                .ForMember(dest => dest.ReplyPostDate, opt => opt.MapFrom(src => src.ReplyPostDate))
                .ForMember(dest => dest.ReplyCommentId, opt => opt.MapFrom(src => src.ReplyCommentId));
        }
    }
}
