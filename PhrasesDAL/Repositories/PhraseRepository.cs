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

        public async Task<List<CompletePhrase>> GetAllComplete()
        {
            string query = @"SELECT *
                        FROM Phrases.Phrase
                        INNER JOIN Phrases.Tag ON Phrases.Phrase.PhraseTagId = Phrases.Tag.ID
                        INNER JOIN Phrases.Region ON Phrases.Phrase.PhraseRegionId = Phrases.Region.ID;";

            var results = await _sqlConnection.QueryAsync<CompletePhrase>(query, param: new {}, transaction: _dbTransaction);
            return results.ToList();
        }

        public async Task<List<CompletePhrase>> GetAllCompleteOrderedByLikes()
        {
            string query = @"SELECT *
                        FROM Phrases.Phrase
                        INNER JOIN Phrases.Tag ON Phrases.Phrase.PhraseTagId = Phrases.Tag.ID
                        INNER JOIN Phrases.Region ON Phrases.Phrase.PhraseRegionId = Phrases.Region.ID
                        ORDER BY Phrases.Phrase.PhraseLikes DESC;";

            var results = await _sqlConnection.QueryAsync<CompletePhrase>(query, param: new { }, transaction: _dbTransaction);
            return results.ToList();
        }

        public async Task<List<CompletePhrase>> GetAllCompleteByTagId(Guid tagId)
        {
            string query = @"SELECT *
                        FROM Phrases.Phrase
                        INNER JOIN Phrases.Tag ON Phrases.Phrase.PhraseTagId = Phrases.Tag.ID
                        INNER JOIN Phrases.Region ON Phrases.Phrase.PhraseRegionId = Phrases.Region.ID
                        WHERE Phrases.Phrase.PhraseTagId = @TagId;";

            var results = await _sqlConnection.QueryAsync<CompletePhrase>(query, param: new { TagId = tagId }, transaction: _dbTransaction); 
            return results.ToList();
        }

        public async Task<List<CompletePhrase>> GetAllCompleteByRegionId(Guid regionId)
        {
            string query = @"SELECT *
                        FROM Phrases.Phrase
                        INNER JOIN Phrases.Tag ON Phrases.Phrase.PhraseTagId = Phrases.Tag.ID
                        INNER JOIN Phrases.Region ON Phrases.Phrase.PhraseRegionId = Phrases.Region.ID
                        WHERE Phrases.Phrase.PhraseRegionId = @RegionId;";

            var results = await _sqlConnection.QueryAsync<CompletePhrase>(query, param: new { RegionId = regionId }, transaction: _dbTransaction);
            return results.ToList();
        }

        public async Task UpdateLikesById(Guid id, int likes)
        {
            var sqlQuery = "UPDATE Phrases.Phrase SET PhraseLikes = @Likes WHERE ID = @Id";

            await _sqlConnection.QueryAsync<Phrase>(sqlQuery, param: new { Likes = likes, Id = id }, transaction: _dbTransaction);
        }
    }
}
