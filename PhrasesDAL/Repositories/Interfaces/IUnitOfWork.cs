using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phrases.DAL.Repositories.Intefaces
{
    public interface IUnitOfWork : IDisposable
    {
        IPhraseRepository _phraseRepository { get; }
        ITagRepository _tagRepository { get; }
        IRegionRepository _regionRepository { get; }
        void Commit();
        new void Dispose();
    }
}
