using AutoMapper;
using Phrases.BLL.Profiles;
using Phrases.BLL.Repositories.Interfaces;
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

namespace Phrases.BLL.Repositories
{
    public class TagService : ITagService
    {
        private IUnitOfWork _unitOfWork;

        public TagService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IBaseResponse<IEnumerable<TagDto>>> GetAll()
        {
            var baseResponse = new BaseResponse<IEnumerable<TagDto>>();
            var tagDtoList = new List<TagDto>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<TagProfile>();
            });

            var mapper = config.CreateMapper();

            try
            {
                var tags = await _unitOfWork._tagRepository.GetAllAsync();

                foreach (var tag in tags)
                {
                    TagDto tagDto = mapper.Map<Tag, TagDto>(tag);
                    tagDtoList.Add(tagDto);
                }

                if (tagDtoList.Count is 0)
                {
                    baseResponse.Description = "0 tags found";
                    baseResponse.StatusCode = StatusCode.NotFound;
                    return baseResponse;
                }

                baseResponse.Data = tagDtoList;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch(Exception e) 
            {
                return new BaseResponse<IEnumerable<TagDto>>()
                {
                    Description = $"{e.Message}"
                };
            }
        }

        public async Task<IBaseResponse<string>> UpdateById(Guid id, Tag tag)
        {
            try
            {
                var tagToUpdate = await _unitOfWork._tagRepository.GetAsync(id);

                if (tagToUpdate is not null)
                {
                    await _unitOfWork._tagRepository.ReplaceAsync(tag);

                    return new BaseResponse<string>()
                    {
                        Description = $"Tag updated!"
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
            catch (Exception e)
            {
                return new BaseResponse<string>()
                {
                    Description = $"{e.Message}"
                };
            }
        }

        public async Task<IBaseResponse<string>> Insert(Tag tag)
        {
            try
            {
                if (tag is not null)
                {
                    var created_id = await _unitOfWork._tagRepository.AddAsync(tag);
                    _unitOfWork.Commit();

                    return new BaseResponse<string>()
                    {
                        Description = $"Tag inserted!"
                    };
                }
                else
                {
                    return new BaseResponse<string>()
                    {
                        Description = $"Tag can`t be empty..."
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
                var tag = await _unitOfWork._tagRepository.GetAsync(id);

                if (tag is not null)
                {
                    await _unitOfWork._tagRepository.DeleteAsync(id);
                    _unitOfWork.Commit();

                    return new BaseResponse<string>()
                    {
                        Description = $"Tag deleted!"
                    };
                }
                else
                {
                    return new BaseResponse<string>()
                    {
                        Description = $"No tag with this id..."
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
