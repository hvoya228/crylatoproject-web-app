using Phrases.Data.Dtos;
using Phrases.Data.Interfaces;
using Phrases.Data.Models;
using Phrases.Data.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phrases.BLL.Repositories.Interfaces
{
    public interface IPhraseService
    {
        Task<IBaseResponse<IEnumerable<CompletePhraseDto>>> GetAllComplete();
        Task<IBaseResponse<IEnumerable<CompletePhraseDto>>> GetAllCompleteOrderedByLikes();
        Task<IBaseResponse<IEnumerable<CompletePhraseDto>>> GetAllCompleteByTagId(Guid tagId);
        Task<IBaseResponse<IEnumerable<CompletePhraseDto>>> GetAllCompleteByRegionId(Guid regionId);
        Task<IBaseResponse<IEnumerable<PhraseDto>>> GetAll();
        Task<IBaseResponse<string>> UpdateById(Guid id, Phrase phrase);
        Task<IBaseResponse<string>> UpdateLikesById(Guid id, int likes);
        Task<IBaseResponse<string>> Insert(Phrase phrase);
        Task<IBaseResponse<string>> DeleteById(Guid id);
    }
}
