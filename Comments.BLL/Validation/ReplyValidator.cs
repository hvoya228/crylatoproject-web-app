using Comments.Data.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.BLL.Validation
{
    public class ReplyValidator : AbstractValidator<ReplyDto>
    {
        public ReplyValidator()
        {
            RuleFor(r => r.ReplyText)
                .NotEmpty().WithMessage("Text is required.")
                .MaximumLength(500).WithMessage("Reply text cannot exceed 500 characters.");

            RuleFor(r => r.ReplyPostDate)
                .Must(BeAValidDate).WithMessage("Invalid date format.");

            RuleFor(r => r.ReplyCommentId)
                .NotEmpty().WithMessage("Id is required.")
                .Must(BeAValidGuid).WithMessage("Invalid Id format.");
        }

        private bool BeAValidDate(DateTime date)
        {
            return date >= DateTime.Now.AddYears(-1);
        }

        private bool BeAValidGuid(Guid guid)
        {
            return guid != Guid.Empty;
        }
    }
}
