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
    public class ReplyService : IReplyService
    {
        private IUnitOfWork _unitOfWork;

        public ReplyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IBaseResponse<IEnumerable<ReplyDto>>> GetAll()
        {
            var baseResponse = new BaseResponse<IEnumerable<ReplyDto>>();
            var replyDtoList = new List<ReplyDto>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ReplyProfile>();
            });

            var mapper = config.CreateMapper();

            try
            {
                var replies = await _unitOfWork.ReplyRepository.GetAsync();

                foreach (var reply in replies)
                {
                    ReplyDto replyDto = mapper.Map<Reply, ReplyDto>(reply);
                    replyDtoList.Add(replyDto);
                }

                if (replyDtoList.Count is 0)
                {
                    baseResponse.Description = "0 replies found";
                    baseResponse.StatusCode = StatusCode.NotFound;
                    return baseResponse;
                }

                baseResponse.Data = replyDtoList;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception e)
            {
                return new BaseResponse<IEnumerable<ReplyDto>>()
                {
                    Description = $"{e.Message}"
                };
            }
        }

        public async Task<IBaseResponse<string>> UpdateById(Guid id, ReplyDto replyDto)
        {
            try
            {
                var replyToUpdate = await _unitOfWork.ReplyRepository.GetByIdAsync(id);

                if (replyToUpdate is not null)
                {
                    if (replyDto is not null)
                    {
                        var config = new MapperConfiguration(cfg =>
                        {
                            cfg.AddProfile<ReplyDtoProfile>();
                        });

                        var mapper = config.CreateMapper();

                        Reply reply = mapper.Map<ReplyDto, Reply>(replyDto);

                        await _unitOfWork.ReplyRepository.UpdateAsync(reply);

                        return new BaseResponse<string>()
                        {
                            Description = $"Reply updated!"
                        };
                    }
                    else
                    {
                        return new BaseResponse<string>()
                        {
                            Description = $"Reply can`t be null..."
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

        public async Task<IBaseResponse<string>> Insert(ReplyDto replyDto)
        {
            try
            {
                if (replyDto is not null)
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.AddProfile<ReplyDtoProfile>();
                    });

                    var mapper = config.CreateMapper();

                    Reply reply = mapper.Map<ReplyDto, Reply>(replyDto);

                    await _unitOfWork.ReplyRepository.InsertAsync(reply);
                    await _unitOfWork.SaveChangesAsync();

                    return new BaseResponse<string>()
                    {
                        Description = $"Reply inserted!"
                    };
                }
                else
                {
                    return new BaseResponse<string>()
                    {
                        Description = $"Reply can`t be empty..."
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
                var reply = await _unitOfWork.ReplyRepository.GetByIdAsync(id);

                if (reply is not null)
                {
                    await _unitOfWork.ReplyRepository.DeleteAsync(id);
                    await _unitOfWork.SaveChangesAsync();

                    return new BaseResponse<string>()
                    {
                        Description = $"Reply deleted!"
                    };
                }
                else
                {
                    return new BaseResponse<string>()
                    {
                        Description = $"No reply with this id..."
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
