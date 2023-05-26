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

        /// <summary>
        /// Execute get query with inner joins to Tag and Region, returns all founded objects
        /// </summary>
        /// <returns>List<CompletePhrase></returns>
        public async Task<List<CompletePhrase>> GetAllComplete()
        {
            string query = @"SELECT *
                        FROM Phrases.Phrase
                        INNER JOIN Phrases.Tag ON Phrases.Phrase.PhraseTagId = Phrases.Tag.ID
                        INNER JOIN Phrases.Region ON Phrases.Phrase.PhraseRegionId = Phrases.Region.ID;";

            var results = await _sqlConnection.QueryAsync<CompletePhrase>(query, param: new {}, transaction: _dbTransaction);
            return results.ToList();
        }

        /// <summary>
        /// Execute get query with inner joins to Tag and Region, returns all founded objects sorted by popularity
        /// </summary>
        /// <returns>List<CompletePhrase></returns>
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

        /// <summary>
        /// Execute get query with inner joins to Tag and Region, returns all founded objects with specific tag id
        /// </summary>
        /// <param name="tagId">Id of Tag in Phrase object</param>
        /// <returns>List<CompletePhrase></returns>
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

        /// <summary>
        /// Execute get query with inner joins to Tag and Region, returns all founded objects with specific region id
        /// </summary>
        /// <param name="regionId">Id of Region in Phrase object</param>
        /// <returns></returns>
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

        /// <summary>
        /// Execute update query for likes in Phrase object
        /// </summary>
        /// <param name="id">Phrase id</param>
        /// <param name="likes">New likes count</param>
        /// <returns>Nothing</returns>
        public async Task UpdateLikesById(Guid id, int likes)
        {
            var sqlQuery = "UPDATE Phrases.Phrase SET PhraseLikes = @Likes WHERE ID = @Id";

            await _sqlConnection.QueryAsync<Phrase>(sqlQuery, param: new { Likes = likes, Id = id }, transaction: _dbTransaction);
        }
    }
}
