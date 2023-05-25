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
    public class FeedbackService : IFeedbackService
    {
        private IUnitOfWork _unitOfWork;

        public FeedbackService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IBaseResponse<IEnumerable<FeedbackDto>>> GetAll()
        {
            var baseResponse = new BaseResponse<IEnumerable<FeedbackDto>>();
            var feedbackDtoList = new List<FeedbackDto>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<FeedbackProfile>();
            });

            var mapper = config.CreateMapper();

            try
            {
                var feedbacks = await _unitOfWork.FeedbackRepository.GetAsync();

                foreach (var feedback in feedbacks)
                {
                    FeedbackDto feedbackDto = mapper.Map<Feedback, FeedbackDto>(feedback);
                    feedbackDtoList.Add(feedbackDto);
                }

                if (feedbackDtoList.Count is 0)
                {
                    baseResponse.Description = "0 feedbacks found";
                    baseResponse.StatusCode = StatusCode.NotFound;
                    return baseResponse;
                }

                baseResponse.Data = feedbackDtoList;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception e)
            {
                return new BaseResponse<IEnumerable<FeedbackDto>>()
                {
                    Description = $"{e.Message}"
                };
            }
        }

        public async Task<IBaseResponse<string>> UpdateById(Guid id, FeedbackDto feedbackDto)
        {
            try
            {
                var feedbackToUpdate = await _unitOfWork.FeedbackRepository.GetByIdAsync(id);

                if (feedbackToUpdate is not null)
                {
                    if (feedbackDto is not null)
                    {
                        var config = new MapperConfiguration(cfg =>
                        {
                            cfg.AddProfile<FeedbackDtoProfile>();
                        });

                        var mapper = config.CreateMapper();

                        Feedback feedback = mapper.Map<FeedbackDto, Feedback>(feedbackDto);

                        await _unitOfWork.FeedbackRepository.UpdateAsync(feedback);

                        return new BaseResponse<string>()
                        {
                            Description = $"Feedback updated!"
                        };
                    }
                    else
                    {
                        return new BaseResponse<string>()
                        {
                            Description = $"Feedback can`t be null..."
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

        public async Task<IBaseResponse<string>> Insert(FeedbackDto feedbackDto)
        {
            try
            {
                if (feedbackDto is not null)
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.AddProfile<FeedbackDtoProfile>();
                    });

                    var mapper = config.CreateMapper();

                    Feedback feedback = mapper.Map<FeedbackDto, Feedback>(feedbackDto);

                    await _unitOfWork.FeedbackRepository.InsertAsync(feedback);
                    await _unitOfWork.SaveChangesAsync();

                    return new BaseResponse<string>()
                    {
                        Description = $"Feedback inserted!"
                    };
                }
                else
                {
                    return new BaseResponse<string>()
                    {
                        Description = $"Feedback can`t be empty..."
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
                var feedback = await _unitOfWork.FeedbackRepository.GetByIdAsync(id);

                if (feedback is not null)
                {
                    await _unitOfWork.FeedbackRepository.DeleteAsync(id);
                    await _unitOfWork.SaveChangesAsync();

                    return new BaseResponse<string>()
                    {
                        Description = $"Feedback deleted!"
                    };
                }
                else
                {
                    return new BaseResponse<string>()
                    {
                        Description = $"No feedback with this id..."
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
