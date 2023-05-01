using Dapper;
using Microsoft.Data.SqlClient;
using PhrasesDAL.Entities;
using PhrasesDAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhrasesDAL.Repositories
{
    public class PhraseRepository : GenericRepository<Phrase>, IPhraseRepository
    {
        public PhraseRepository(SqlConnection sqlConnection, IDbTransaction dbTransaction) :
                              base(sqlConnection, dbTransaction, "Phrase")
        {
        }

        public async Task<IEnumerable<Phrase>> GetAllByTagIdOrderByIdAsync(int tagId)
        {
            string sql = @"SELECT * FROM Phrase WHERE TagId = @TagId ORDER BY Id DESC;";
            var results = await _sqlConnection.QueryAsync<Phrase>(sql, param: new { TagId = tagId },
                transaction: _dbTransaction);
            return results;
        }

        public async Task<IEnumerable<Phrase>> GetAllByTagIdOrderByLikesAsync(int tagId)
        {
            string sql = @"SELECT * FROM Phrase WHERE TagId = @TagId ORDER BY Likes DESC;";
            var results = await _sqlConnection.QueryAsync<Phrase>(sql, param: new {TagId = tagId},
                transaction: _dbTransaction);
            return results;
        }

        public async Task UpdateLikesAsync(int id, int likes)
        {
            var sqlQuery = "UPDATE Phrase SET Likes = @Likes WHERE Id = @Id";

            await _sqlConnection.QueryAsync<Phrase>(sqlQuery, param: new { Likes = likes, Id = id },
                transaction: _dbTransaction);
        }
    }
}
