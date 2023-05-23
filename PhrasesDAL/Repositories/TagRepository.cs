using Microsoft.Data.SqlClient;
using Phrases.DAL.Repositories.Intefaces;
using Phrases.Data.Models;
using System.Data;

namespace Phrases.DAL.Repositories
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        public TagRepository(SqlConnection sqlConnection, IDbTransaction dbTransaction) : 
                        base(sqlConnection, dbTransaction, "Phrases.Tag"){}
    }
}
