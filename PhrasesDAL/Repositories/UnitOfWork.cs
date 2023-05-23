using Phrases.DAL.Repositories.Intefaces;
using System.Data;

namespace Phrases.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public IPhraseRepository _phraseRepository { get; }
        public ITagRepository _tagRepository { get; }
        public IRegionRepository _regionRepository { get; }

        readonly IDbTransaction _dbTransaction;

        public UnitOfWork(IPhraseRepository phraseRepository, ITagRepository tagRepository, 
                          IRegionRepository regionRepository, IDbTransaction dbTransaction)
        {
            _phraseRepository = phraseRepository;
            _tagRepository = tagRepository;
            _regionRepository = regionRepository;
            _dbTransaction = dbTransaction;
        }

        public void Commit()
        {
            try
            {
                _dbTransaction.Commit();
            }
            catch (Exception ex)
            {
                _dbTransaction.Rollback();
                Console.WriteLine(ex.Message);
            }
        }
        public void Dispose()
        {
            _dbTransaction.Connection?.Close();
            _dbTransaction.Connection?.Dispose();
            _dbTransaction.Dispose();
        }
    }
}
