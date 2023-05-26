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
    public class RegionService : IRegionService
    {
        private IUnitOfWork _unitOfWork;

        public RegionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IBaseResponse<IEnumerable<RegionDto>>> GetAll()
        {
            var baseResponse = new BaseResponse<IEnumerable<RegionDto>>();
            var regionDtoList = new List<RegionDto>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<RegionProfile>();
            });

            var mapper = config.CreateMapper();

            try
            {
                var regions = await _unitOfWork._regionRepository.GetAllAsync();

                foreach (var region in regions)
                {
                    RegionDto regionDto = mapper.Map<Region, RegionDto>(region);
                    regionDtoList.Add(regionDto);
                }

                if (regionDtoList.Count is 0)
                {
                    baseResponse.Description = "0 regions found";
                    baseResponse.StatusCode = StatusCode.NotFound;
                    return baseResponse;
                }

                baseResponse.ResultsCount = regionDtoList.Count;
                baseResponse.Description = "Success!";
                baseResponse.Data = regionDtoList;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception e)
            {
                return new BaseResponse<IEnumerable<RegionDto>>()
                {
                    Description = $"{e.Message}"
                };
            }
        }

        public async Task<IBaseResponse<string>> UpdateById(Guid id, Region region)
        {
            try
            {
                var regionToUpdate = await _unitOfWork._regionRepository.GetAsync(id);

                if (regionToUpdate is not null)
                {
                    await _unitOfWork._regionRepository.ReplaceAsync(region);

                    return new BaseResponse<string>()
                    {
                        Description = $"Region updated!"
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

        public async Task<IBaseResponse<string>> Insert(Region region)
        {
            try
            {
                if (region is not null)
                {
                    var created_id = await _unitOfWork._regionRepository.AddAsync(region);
                    _unitOfWork.Commit();

                    return new BaseResponse<string>()
                    {
                        Description = $"Region inserted!"
                    };
                }
                else
                {
                    return new BaseResponse<string>()
                    {
                        Description = $"Region can`t be empty..."
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
                var region = await _unitOfWork._regionRepository.GetAsync(id);

                if (region is not null)
                {
                    await _unitOfWork._regionRepository.DeleteAsync(id);
                    _unitOfWork.Commit();

                    return new BaseResponse<string>()
                    {
                        Description = $"Region deleted!"
                    };
                }
                else
                {
                    return new BaseResponse<string>()
                    {
                        Description = $"No region with this id..."
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
