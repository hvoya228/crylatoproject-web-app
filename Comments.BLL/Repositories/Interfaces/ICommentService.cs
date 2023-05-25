using Comments.Data.Dtos;
using Comments.Data.Interfaces;
using Comments.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.BLL.Repositories.Interfaces
{
    public interface ICommentService
    {
        Task<IBaseResponse<IEnumerable<CompleteCommentDto>>> GetAllComplete();
        Task<IBaseResponse<IEnumerable<CommentDto>>> GetAll();
        Task<IBaseResponse<string>> UpdateById(Guid id, CommentDto commentDto);
        Task<IBaseResponse<string>> Insert(CommentDto commentDto);
        Task<IBaseResponse<string>> DeleteById(Guid id);
    }
}
