using Microsoft.EntityFrameworkCore;
using System;
using TodoAppHexagon.Adapaters.SqlServer.Data;
using TodoAppHexagon.Core.AdapterServices;
using TodoAppHexagon.Core.Ports;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'AppDbContextConnection' not found.");
builder.Services.AddDbContext<TodoDbContext>(options => options.UseSqlServer(connectionString));
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddTransient<ITodoRepository, SqlServerTodoRepository>();
builder.Services.AddTransient<ITodoService, TodoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
