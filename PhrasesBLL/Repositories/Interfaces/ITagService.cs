using Phrases.Data.Dtos;
using Phrases.Data.Interfaces;
using Phrases.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phrases.BLL.Repositories.Interfaces
{
    public interface ITagService
    {
        Task<IBaseResponse<IEnumerable<TagDto>>> GetAll();
        Task<IBaseResponse<string>> UpdateById(Guid id, Tag tag);
        Task<IBaseResponse<string>> Insert(Tag tag);
        Task<IBaseResponse<string>> DeleteById(Guid id);
    }
}
