using Comments.BLL.Repositories;
using Comments.BLL.Repositories.Interfaces;
using Comments.BLL.Validation;
using Comments.DAL;
using Comments.DAL.Repositories;
using Comments.DAL.Repositories.Interfaces;
using Comments.Data.Dtos;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Connection to database
builder.Services.AddDbContext<CommentsContext>(configurations =>
{
    configurations.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        options => options.MigrationsAssembly("Comments.Migrations"));
});

//Dependency injection

//AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//Repositories
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<IReplyRepository, ReplyRepository>();
builder.Services.AddScoped<IFeedbackRepository, FeedbackRepository>();

//Unit of work
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

//Services
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<IFeedbackService, FeedbackService>();
builder.Services.AddScoped<IReplyService, ReplyService>();

//Validators
builder.Services.AddTransient<IValidator<CommentDto>, CommentValidator>();
builder.Services.AddTransient<IValidator<ReplyDto>, ReplyValidator>();

//

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
