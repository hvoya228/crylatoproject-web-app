using AutoMapper;
using Phrases.BLL.Profiles;
using Phrases.BLL.Repositories.Interfaces;
using Phrases.DAL.Repositories;
using Phrases.DAL.Repositories.Intefaces;
using Phrases.Data.Dtos;
using Phrases.Data.Enums;
using Phrases.Data.Interfaces;
using Phrases.Data.Models;
using Phrases.Data.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Phrases.BLL.Repositories
{
    public class PhraseService : IPhraseService
    {
        private IUnitOfWork _unitOfWork;

        public PhraseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IBaseResponse<IEnumerable<CompletePhraseDto>>> GetAllComplete()
        {
            var baseResponse = new BaseResponse<IEnumerable<CompletePhraseDto>>();
            var completePhraseDtoList = new List<CompletePhraseDto>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CompletePhraseProfile>();
            });

            var mapper = config.CreateMapper();

            try
            {
                var completePhrases = await _unitOfWork._phraseRepository.GetAllComplete();

                foreach(var completePhrase in completePhrases)
                {
                    CompletePhraseDto completePhraseDto = mapper.Map<CompletePhrase, CompletePhraseDto>(completePhrase);
                    completePhraseDtoList.Add(completePhraseDto);
                }

                if (completePhraseDtoList.Count is 0)
                {
                    baseResponse.Description = "0 phrases found";
                    baseResponse.StatusCode = StatusCode.NotFound;
                    return baseResponse;
                }

                baseResponse.Data = completePhraseDtoList;
                baseResponse.StatusCode = StatusCode.OK;
                return baseResponse;
            }
            catch(Exception e)
            {
                return new BaseResponse<IEnumerable<CompletePhraseDto>>()
                {
                    Description = $"{e.Message}"
                };
            }
        }

        public async Task<IBaseResponse<IEnumerable<CompletePhraseDto>>> GetAllCompleteOrderedByLikes()
        {
            var baseResponse = new BaseResponse<IEnumerable<CompletePhraseDto>>();
            var completePhraseDtoList = new List<CompletePhraseDto>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CompletePhraseProfile>();
            });

            var mapper = config.CreateMapper();

            try
            {
                var completePhrases = await _unitOfWork._phraseRepository.GetAllCompleteOrderedByLikes();

                foreach (var completePhrase in completePhrases)
                {
                    CompletePhraseDto completePhraseDto = mapper.Map<CompletePhrase, CompletePhraseDto>(completePhrase);
                    completePhraseDtoList.Add(completePhraseDto);
                }

                if (completePhraseDtoList.Count is 0)
                {
                    baseResponse.Description = "0 phrases found";
                    baseResponse.StatusCode = StatusCode.NotFound;
                    return baseResponse;
                }

                baseResponse.Data = completePhraseDtoList;
                baseResponse.StatusCode = StatusCode.OK;
                return baseResponse;
            }
            catch (Exception e)
            {
                return new BaseResponse<IEnumerable<CompletePhraseDto>>()
                {
                    Description = $"{e.Message}"
                };
            }
        }

        public async Task<IBaseResponse<IEnumerable<CompletePhraseDto>>> GetAllCompleteByTagId(Guid tagId)
        {
            var baseResponse = new BaseResponse<IEnumerable<CompletePhraseDto>>();
            var completePhraseDtoList = new List<CompletePhraseDto>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CompletePhraseProfile>();
            });

            var mapper = config.CreateMapper();

            try
            {
                var completePhrases = await _unitOfWork._phraseRepository.GetAllCompleteByTagId(tagId);

                foreach (var completePhrase in completePhrases)
                {
                    CompletePhraseDto completePhraseDto = mapper.Map<CompletePhrase, CompletePhraseDto>(completePhrase);
                    completePhraseDtoList.Add(completePhraseDto);
                }

                if (completePhraseDtoList.Count is 0)
                {
                    baseResponse.Description = "0 phrases found";
                    baseResponse.StatusCode = StatusCode.NotFound;
                    return baseResponse;
                }

                baseResponse.Data = completePhraseDtoList;
                baseResponse.StatusCode = StatusCode.OK;
                return baseResponse;
            }
            catch (Exception e)
            {
                return new BaseResponse<IEnumerable<CompletePhraseDto>>()
                {
                    Description = $"{e.Message}"
                };
            }
        }

        public async Task<IBaseResponse<IEnumerable<CompletePhraseDto>>> GetAllCompleteByRegionId(Guid regionId)
        {
            var baseResponse = new BaseResponse<IEnumerable<CompletePhraseDto>>();
            var completePhraseDtoList = new List<CompletePhraseDto>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CompletePhraseProfile>();
            });

            var mapper = config.CreateMapper();

            try
            {
                var completePhrases = await _unitOfWork._phraseRepository.GetAllCompleteByRegionId(regionId);

                foreach (var completePhrase in completePhrases)
                {
                    CompletePhraseDto completePhraseDto = mapper.Map<CompletePhrase, CompletePhraseDto>(completePhrase);
                    completePhraseDtoList.Add(completePhraseDto);
                }

                if (completePhraseDtoList.Count is 0)
                {
                    baseResponse.Description = "0 phrases found";
                    baseResponse.StatusCode = StatusCode.NotFound;
                    return baseResponse;
                }

                baseResponse.Data = completePhraseDtoList;
                baseResponse.StatusCode = StatusCode.OK;
                return baseResponse;
            }
            catch (Exception e)
            {
                return new BaseResponse<IEnumerable<CompletePhraseDto>>()
                {
                    Description = $"{e.Message}"
                };
            }
        }

        public async Task<IBaseResponse<IEnumerable<PhraseDto>>> GetAll()
        {
            var baseResponse = new BaseResponse<IEnumerable<PhraseDto>>();
            var phraseDtoList = new List<PhraseDto>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<PhraseProfile>();
            });

            var mapper = config.CreateMapper();

            try
            {
                var phrases = await _unitOfWork._phraseRepository.GetAllAsync();

                foreach (var phrase in phrases)
                {
                    PhraseDto phraseDto = mapper.Map<Phrase, PhraseDto>(phrase);
                    phraseDtoList.Add(phraseDto);
                }

                if (phraseDtoList.Count is 0)
                {
                    baseResponse.Description = "0 phrases found";
                    baseResponse.StatusCode = StatusCode.NotFound;
                    return baseResponse;
                }

                baseResponse.Data = phraseDtoList;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception e)
            {
                return new BaseResponse<IEnumerable<PhraseDto>>()
                {
                    Description = $"{e.Message}"
                };
            }
        }

        public async Task<IBaseResponse<string>> Insert(Phrase phrase)
        {
            try
            {
                if (phrase is not null)
                {
                    var created_id = await _unitOfWork._phraseRepository.AddAsync(phrase);
                    _unitOfWork.Commit();

                    return new BaseResponse<string>()
                    {
                        Description = $"Phrase inserted!"
                    };
                }
                else
                {
                    return new BaseResponse<string>()
                    {
                        Description = $"Phrase can`t be empty..."
                    };
                }
            }
            catch(Exception e)
            {
                return new BaseResponse<string>()
                {
                    Description = $"{e.Message}"
                };
            }
        }

        public async Task<IBaseResponse<string>> UpdateById(Guid id, Phrase phrase)
        {
            try
            {
                var phraseToUpdate = await _unitOfWork._phraseRepository.GetAsync(id);

                if (phraseToUpdate is not null)
                {
                    await _unitOfWork._phraseRepository.ReplaceAsync(phrase);

                    return new BaseResponse<string>()
                    {
                        Description = $"Phrase updated!"
                    };
                }
                else
                {
                    return new BaseResponse<string>()
                    {
                        Description = $"No model with this id was found in database..."
                    };
                }
            }
            catch(Exception e)
            {
                return new BaseResponse<string>()
                {
                    Description = $"{e.Message}"
                };
            }
        }

        public async Task<IBaseResponse<string>> UpdateLikesById(Guid id, int likes)
        {
            try
            {
                if (likes > 0)
                {
                    await _unitOfWork._phraseRepository.UpdateLikesById(id, likes);
                    _unitOfWork.Commit();

                    return new BaseResponse<string>()
                    {
                        Description = $"Likes updated!"
                    };
                }
                else
                {
                    return new BaseResponse<string>()
                    {
                        Description = $"Likes can`t be less than 0..."
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
                var phrase = await _unitOfWork._phraseRepository.GetAsync(id);

                if(phrase is not null)
                {
                    await _unitOfWork._phraseRepository.DeleteAsync(id);
                    _unitOfWork.Commit();

                    return new BaseResponse<string>()
                    {
                        Description = $"Phrase deleted!"
                    };
                }
                else
                {
                    return new BaseResponse<string>()
                    {
                        Description = $"No phrase with this id..."
                    };
                }
            }
            catch(Exception e)
            {
                return new BaseResponse<string>()
                {
                    Description = $"{e.Message}"
                };
            }
        }
    }
}
