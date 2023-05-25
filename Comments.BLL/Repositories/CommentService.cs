using AutoMapper;
using Comments.BLL.Profiles;
using Comments.BLL.Repositories.Interfaces;
using Comments.DAL.Repositories.Interfaces;
using Comments.Data.Dtos;
using Comments.Data.Enums;
using Comments.Data.Interfaces;
using Comments.Data.Models;
using Comments.Data.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.BLL.Repositories
{
    public class CommentService : ICommentService
    {
        private IUnitOfWork _unitOfWork;

        public CommentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IBaseResponse<IEnumerable<CompleteCommentDto>>> GetAllComplete()
        {
            var baseResponse = new BaseResponse<IEnumerable<CompleteCommentDto>>();
            var completeCommentDtoList = new List<CompleteCommentDto>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CompleteCommentProfile>();
            });

            var mapper = config.CreateMapper();

            try
            {
                var completeComments = await _unitOfWork.CommentRepository.GetAllComplete();

                foreach(var completeComment in completeComments) 
                {
                    CompleteCommentDto completeCommentDto = mapper.Map<CompleteComment, CompleteCommentDto>(completeComment);
                    completeCommentDtoList.Add(completeCommentDto);
                }

                if (completeCommentDtoList.Count is 0)
                {
                    baseResponse.Description = "0 comments found";
                    baseResponse.StatusCode = StatusCode.NotFound;
                    return baseResponse;
                }

                baseResponse.Data = completeCommentDtoList;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch(Exception e)
            {
                return new BaseResponse<IEnumerable<CompleteCommentDto>>()
                {
                    Description = $"{e.Message}"
                };
            }
        }

        public async Task<IBaseResponse<IEnumerable<CommentDto>>> GetAll()
        {
            var baseResponse = new BaseResponse<IEnumerable<CommentDto>>();
            var commentDtoList = new List<CommentDto>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CommentProfile>();
            });

            var mapper = config.CreateMapper();

            try
            {
                var comments = await _unitOfWork.CommentRepository.GetAsync();

                foreach (var comment in comments)
                {
                    CommentDto commentDto = mapper.Map<Comment, CommentDto>(comment);
                    commentDtoList.Add(commentDto);
                }

                if (commentDtoList.Count is 0)
                {
                    baseResponse.Description = "0 comments found";
                    baseResponse.StatusCode = StatusCode.NotFound;
                    return baseResponse;
                }

                baseResponse.Data = commentDtoList;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception e)
            {
                return new BaseResponse<IEnumerable<CommentDto>>()
                {
                    Description = $"{e.Message}"
                };
            }
        }

        public async Task<IBaseResponse<string>> UpdateById(Guid id, CommentDto commentDto)
        {
            try
            {
                var commentToUpdate = await _unitOfWork.CommentRepository.GetByIdAsync(id);

                if (commentToUpdate is not null)
                {
                    if (commentDto is not null)
                    {
                        var config = new MapperConfiguration(cfg =>
                        {
                            cfg.AddProfile<CommentDtoProfile>();
                        });

                        var mapper = config.CreateMapper();

                        Comment comment = mapper.Map<CommentDto, Comment>(commentDto);

                        await _unitOfWork.CommentRepository.UpdateAsync(comment);

                        return new BaseResponse<string>()
                        {
                            Description = $"Comment updated!"
                        };
                    }
                    else
                    {
                        return new BaseResponse<string>()
                        {
                            Description = $"Comment can`t be null..."
                        };
                    }
                }
                else
                {
                    return new BaseResponse<string>()
                    {
                        Description = $"No model with this id was found in database..."
                    };
                }
            }
            catch (Exception e)
            {
                return new BaseResponse<string>()
                {
                    Description = $"{e.Message}"
                };
            }
        }

        public async Task<IBaseResponse<string>> Insert(CommentDto commentDto)
        {
            try
            {
                if (commentDto is not null)
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.AddProfile<CommentDtoProfile>();
                    });

                    var mapper = config.CreateMapper();

                    Comment comment = mapper.Map<CommentDto, Comment>(commentDto);

                    await _unitOfWork.CommentRepository.InsertAsync(comment);
                    await _unitOfWork.SaveChangesAsync();

                    return new BaseResponse<string>()
                    {
                        Description = $"Comment inserted!"
                    };
                }
                else
                {
                    return new BaseResponse<string>()
                    {
                        Description = $"Comment can`t be empty..."
                    };
                }
            }
            catch (Exception e)
            {
                return new BaseResponse<string>()
                {
                    Description = $"{e.Message}"
                };
            }
        }

        public async Task<IBaseResponse<string>> DeleteById(Guid id)
        {
            try
            {
                var comment = await _unitOfWork.CommentRepository.GetByIdAsync(id);

                if (comment is not null)
                {
                    await _unitOfWork.CommentRepository.DeleteAsync(id);
                    await _unitOfWork.SaveChangesAsync();

                    return new BaseResponse<string>()
                    {
                        Description = $"Comment deleted!"
                    };
                }
                else
                {
                    return new BaseResponse<string>()
                    {
                        Description = $"No comment with this id..."
                    };
                }
            }
            catch (Exception e)
            {
                return new BaseResponse<string>()
                {
                    Description = $"{e.Message}"
                };
            }
        }
    }
}
