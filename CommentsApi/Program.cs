using Comments.DAL;
using Comments.DAL.Data;
using Comments.DAL.Data.Repositories;
using Comments.DAL.Interfaces;
using Comments.DAL.Interfaces.Repositories;
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

//builder.Services.AddScoped<ICommentsRepository, CommentsRepository>();
//builder.Services.AddScoped<IReactionsRepository, ReactionsRepository>();
//builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


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
