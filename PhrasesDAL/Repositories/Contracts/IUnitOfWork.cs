using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhrasesDAL.Repositories.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IPhraseRepository _phraseRepository { get; }
        ITagRepository _tagRepository { get; }
        void Commit();
        new void Dispose();
    }
}
