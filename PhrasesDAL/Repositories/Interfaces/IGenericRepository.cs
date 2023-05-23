using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phrases.DAL.Repositories.Intefaces
{
    public interface IGenericRepository<T>
    {
        Task<List<T>> GetAllAsync();
        Task DeleteAsync(Guid id);
        Task<T> GetAsync(Guid id);
        Task<int> AddRangeAsync(IEnumerable<T> list);
        Task ReplaceAsync(T t);
        Task<Guid> AddAsync(T t);
    }
}
