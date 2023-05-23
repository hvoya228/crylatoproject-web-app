using Dapper;
using Microsoft.Data.SqlClient;
using Phrases.DAL.Repositories.Intefaces;
using Phrases.Data.Models;
using System.Data;

namespace Phrases.DAL.Repositories
{
    public class PhraseRepository : GenericRepository<Phrase>, IPhraseRepository
    {
        public PhraseRepository(SqlConnection sqlConnection, IDbTransaction dbTransaction) :
                           base(sqlConnection, dbTransaction, "Phrases.Phrase"){}

        public async Task<IEnumerable<Phrase>> GetAllByTagIdOrderByIdAsync(Guid tagId)
        {
            string sql = @"SELECT * FROM Phrase WHERE TagId = @TagId ORDER BY Id DESC;";
            var results = await _sqlConnection.QueryAsync<Phrase>(sql, param: new { TagId = tagId }, transaction: _dbTransaction);
            return results;
        }

        public async Task<IEnumerable<Phrase>> GetAllByTagIdOrderByLikesAsync(Guid tagId)
        {
            string sql = @"SELECT * FROM Phrase WHERE TagId = @TagId ORDER BY Likes DESC;";
            var results = await _sqlConnection.QueryAsync<Phrase>(sql, param: new {TagId = tagId}, transaction: _dbTransaction);
            return results;
        }

        public async Task UpdateLikesAsync(Guid id, int likes)
        {
            var sqlQuery = "UPDATE Phrase SET Likes = @Likes WHERE ID = @Id";

            await _sqlConnection.QueryAsync<Phrase>(sqlQuery, param: new { Likes = likes, Id = id }, transaction: _dbTransaction);
        }
    }
}
