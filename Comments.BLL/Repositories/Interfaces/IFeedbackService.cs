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
    public interface IFeedbackService
    {
        Task<IBaseResponse<IEnumerable<FeedbackDto>>> GetAll();
        Task<IBaseResponse<string>> UpdateById(Guid id, FeedbackDto feedbackDto);
        Task<IBaseResponse<string>> Insert(FeedbackDto feedbackDto);
        Task<IBaseResponse<string>> DeleteById(Guid id);
    }
}
