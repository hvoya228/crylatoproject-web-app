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
                              base(sqlConnection, dbTransaction, "Phrases.Phrase")
        {
        }
    }
}
