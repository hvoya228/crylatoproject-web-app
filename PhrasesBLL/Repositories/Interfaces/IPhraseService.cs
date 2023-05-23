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
        Task<IBaseResponse<IEnumerable<Phrase>>> GetAllPhrases();
    }
}
