using Comments.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.DAL.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly CommentsContext databaseContext;

        protected readonly DbSet<TEntity> table;

        /// <summary>
        /// Execute get query, returns all founded objects
        /// </summary>
        /// <returns>IEnumerable<TEntity></returns>
        public virtual async Task<IEnumerable<TEntity>> GetAsync() => await table.ToListAsync();

        public virtual async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await table.FindAsync(id);
        }

        /// <summary>
        /// Execute Insert query to add model in table
        /// </summary>
        /// <param name="entity">Specific model</param>
        /// <returns>Nothing</returns>
        public virtual async Task InsertAsync(TEntity entity) => await table.AddAsync(entity);

        /// <summary>
        /// Execute update query to update model in table
        /// </summary>
        /// <param name="entity">Specific model</param>
        /// <returns>Nothing</returns>
        public virtual async Task UpdateAsync(TEntity entity) =>
            await Task.Run(() => table.Update(entity));

        /// <summary>
        /// Execute delete query to delete model in table
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Nothing</returns>
        public virtual async Task DeleteAsync(Guid id)
        {
            var entity = await GetByIdAsync(id);
            await Task.Run(() => table.Remove(entity));
        }

        public GenericRepository(CommentsContext databaseContext)
        {
            this.databaseContext = databaseContext;
            table = this.databaseContext.Set<TEntity>();
        }
    }
}
