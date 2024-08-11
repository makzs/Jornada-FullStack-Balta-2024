using Lazuli.Api.Data;
using Lazuli.Api.Handlers;
using Lazuli.Core.Handlers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlite("Data Source=Lazuli.db"));
builder.Services.AddTransient<ICategoryHandler, CategoryHandler>();
builder.Services.AddTransient<ITransactionHandler, TransactionHandler>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
