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
    public interface IReplyService
    {
        Task<IBaseResponse<IEnumerable<ReplyDto>>> GetAll();
        Task<IBaseResponse<string>> UpdateById(Guid id, ReplyDto replyDto);
        Task<IBaseResponse<string>> Insert(ReplyDto replyDto);
        Task<IBaseResponse<string>> DeleteById(Guid id);
    }
}
