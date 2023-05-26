using Comments.Data.Dtos;
using Comments.Data.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.BLL.Validation
{
    public class CommentValidator : AbstractValidator<CommentDto>
    {
        public CommentValidator()
        {
            RuleFor(c => c.CommentTheme)
                .MaximumLength(100).WithMessage("Comment theme cannot exceed 100 characters.");

            RuleFor(c => c.CommentText)
                .NotEmpty().WithMessage("Text is required.")
                .MaximumLength(500).WithMessage("Comment text cannot exceed 500 characters.");

            RuleFor(c => c.CommentPostDate)
                .Must(BeAValidDate).WithMessage("Invalid date format.");

            RuleFor(c => c.CommentFeedbackId)
                .NotEmpty();
        }

        private bool BeAValidDate(DateTime date)
        {
            return date >= DateTime.Now.AddYears(-1);
        }
    }
}
