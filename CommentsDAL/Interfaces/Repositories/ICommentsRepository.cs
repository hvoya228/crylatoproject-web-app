using Comments.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.DAL.Interfaces.Repositories
{
    public interface ICommentsRepository : IRepository<Comment>
    {
    }
}
