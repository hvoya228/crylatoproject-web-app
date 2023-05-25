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
    public interface IRegionService
    {
        Task<IBaseResponse<IEnumerable<RegionDto>>> GetAll();
        Task<IBaseResponse<string>> UpdateById(Guid id, Region region);
        Task<IBaseResponse<string>> Insert(Region region);
        Task<IBaseResponse<string>> DeleteById(Guid id);
    }
}
