using PhrasesDAL.Repositories.Contracts;
using System.Data;

namespace PhrasesDAL.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public IPhraseRepository _phraseRepository { get; }
        public ITagRepository _tagRepository { get; }
        public ILikeRepository _likeRepository { get; }


        readonly IDbTransaction _dbTransaction;

        public UnitOfWork(IPhraseRepository phraseRepository, ITagRepository tagRepository, ILikeRepository likeRepository,
                          IDbTransaction dbTransaction)
        {
            _phraseRepository = phraseRepository;
            _tagRepository = tagRepository;
            _likeRepository = likeRepository;
            _dbTransaction = dbTransaction;
        }

        public void Commit()
        {
            try
            {
                _dbTransaction.Commit();
                // By adding this we can have muliple transactions as part of a single request
                //_dbTransaction.Connection.BeginTransaction();
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
