using Phrases.BLL.Repositories.Interfaces;
using Phrases.DAL.Repositories;
using Phrases.DAL.Repositories.Intefaces;
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
    public class PhraseService : IPhraseService
    {
        private IUnitOfWork _unitOfWork;

        public PhraseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IBaseResponse<IEnumerable<Phrase>>> GetAllPhrases()
        {
            var baseResponse = new BaseResponse<IEnumerable<Phrase>>();

            try
            {
                var phrases = await _unitOfWork._phraseRepository.GetAllAsync();

                if(phrases.Count is 0)
                {
                    baseResponse.Description = "0 phrases found";
                    baseResponse.StatusCode = StatusCode.NotFound;
                    return baseResponse;
                }

                baseResponse.Data = phrases;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception e) 
            {
                return new BaseResponse<IEnumerable<Phrase>>()
                {
                    Description = $"GetAllPhrases: {e.Message}"
                };
            }
        }
    }
}
