using Microsoft.Data.SqlClient;
using Phrases.DAL.Repositories.Intefaces;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Text;
using Dapper;
using System.Collections;

namespace Phrases.DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected SqlConnection _sqlConnection;

        protected IDbTransaction _dbTransaction;

        private readonly string _tableName;

        protected GenericRepository(SqlConnection sqlConnection, IDbTransaction dbTransaction, string tableName)
        {
            _sqlConnection = sqlConnection;
            _dbTransaction = dbTransaction;
            _tableName = tableName;
        }

        /// <summary>
        /// Returns all objects from specific table - T
        /// </summary>
        /// <returns>List<T></returns>
        public async Task<List<T>> GetAllAsync()
        {
            var result = await _sqlConnection.QueryAsync<T>($"SELECT * FROM {_tableName}", transaction: _dbTransaction);

            return result.ToList();
        }

        /// <summary>
        /// Returns specific object from specific table - T
        /// </summary>
        /// <param name="id">Object id</param>
        /// <returns>Nothing</returns>
        /// <exception cref="KeyNotFoundException">Id not found exception</exception>
        public async Task<T> GetAsync(Guid id)
        {
            var result = await _sqlConnection.QuerySingleOrDefaultAsync<T>($"SELECT * FROM {_tableName} WHERE ID=@Id",
                param: new { Id = id },
                transaction: _dbTransaction);

            if (result == null) { throw new KeyNotFoundException($"{_tableName} with id [{id}] could not be found."); }

            return result;
        }

        /// <summary>
        /// Delete specific object from database
        /// </summary>
        /// <param name="id">Object id</param>
        /// <returns>Nothing</returns>
        public async Task DeleteAsync(Guid id)
        {
            await _sqlConnection.ExecuteAsync($"DELETE FROM {_tableName} WHERE ID=@Id",
                param: new { Id = id }, 
                transaction: _dbTransaction);
        }

        /// <summary>
        /// Adds specific object - T to specific table - T
        /// </summary>
        /// <param name="t">Model</param>
        /// <returns>Guid newID</returns>
        public async Task<Guid> AddAsync(T t)
        {
            var insertQuery = GenerateInsertQuery();
            var newId = await _sqlConnection.ExecuteScalarAsync<Guid>(insertQuery,
                param: t,
                transaction: _dbTransaction);

            return newId;
        }

        public async Task<int> AddRangeAsync(IEnumerable<T> list)
        {
            var inserted = 0;
            var query = GenerateInsertQuery();

            inserted += await _sqlConnection.ExecuteAsync(query,
                param: list);

            return inserted;
        }

        /// <summary>
        /// Updates specific object - T in specific table - T
        /// </summary>
        /// <param name="t">Model</param>
        /// <returns>Nothing</returns>
        public async Task ReplaceAsync(T t)
        {
            var updateQuery = GenerateUpdateQuery();

            await _sqlConnection.ExecuteAsync(updateQuery,
                param: t,
                transaction: _dbTransaction);
        }

        private IEnumerable<PropertyInfo> GetProperties => typeof(T).GetProperties();

        private static List<string> GenerateListOfProperties(IEnumerable<PropertyInfo> listOfProperties)
        {
            return (from prop in listOfProperties
                    let attributes = prop.GetCustomAttributes(typeof(DescriptionAttribute), false)
                    where attributes.Length <= 0 || (attributes[0] as DescriptionAttribute)?.Description != "ignore"
                    select prop.Name)
                    .ToList();
        }

        private string GenerateUpdateQuery()
        {
            var updateQuery = new StringBuilder($"UPDATE {_tableName} SET ");
            var properties = GenerateListOfProperties(GetProperties);

            properties.ForEach(property =>
            {
                if (!property.Equals("ID"))
                {
                    updateQuery.Append($"{property}=@{property},");
                }
            });

            updateQuery.Remove(updateQuery.Length - 1, 1);
            updateQuery.Append(" WHERE ID=@Id");

            return updateQuery.ToString();
        }

        private string GenerateInsertQuery()
        {
            var insertQuery = new StringBuilder($"INSERT INTO {_tableName} ");
            insertQuery.Append("(");
            var properties = GenerateListOfProperties(GetProperties);

            properties.Remove("ID");

            properties.ForEach(prop => { insertQuery.Append($"[{prop}],"); });
            insertQuery
                .Remove(insertQuery.Length - 1, 1)
                .Append(") VALUES (");

            properties.ForEach(prop => { insertQuery.Append($"@{prop},"); });
            insertQuery
                .Remove(insertQuery.Length - 1, 1)
                .Append(")");

            insertQuery.Append("; SELECT SCOPE_IDENTITY()");

            return insertQuery.ToString();
        }
    }
}
