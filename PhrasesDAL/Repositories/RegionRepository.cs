using Microsoft.Data.SqlClient;
using Phrases.DAL.Repositories.Intefaces;
using Phrases.Data.Models;
using System.Data;

namespace Phrases.DAL.Repositories
{
    public class RegionRepository : GenericRepository<Region>, IRegionRepository
    {
        public RegionRepository(SqlConnection sqlConnection, IDbTransaction dbTransaction) :
                           base(sqlConnection, dbTransaction, "Phrases.Region"){}
    }
}
