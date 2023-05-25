using Comments.BLL.Repositories;
using Comments.BLL.Repositories.Interfaces;
using Comments.DAL;
using Comments.DAL.Repositories;
using Comments.DAL.Repositories.Interfaces;
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
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<IReplyRepository, ReplyRepository>();
builder.Services.AddScoped<IFeedbackRepository, FeedbackRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<IFeedbackService, FeedbackService>();
builder.Services.AddScoped<IReplyService, ReplyService>();

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
