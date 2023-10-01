using System.Reflection;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TodoAppHexagon.Adapaters.SqlServer.Data;
using TodoAppHexagon.Core.AdapterServices;
using TodoAppHexagon.Core.CQRS.Commands.CreateTodoItem;
using TodoAppHexagon.Core.Ports;
using TodoAppHexagon.Core.Services;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
                       throw new InvalidOperationException("Connection string 'AppDbContextConnection' not found.");
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
builder.Services.AddDbContext<TodoDbContext>(options => options.UseSqlServer(connectionString));
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IMediator, Mediator>();
builder.Services.AddMediatR(typeof(CreateTodoItemCommandHandler).GetTypeInfo().Assembly);
builder.Services.AddTransient<ITodoRepository, SqlServerTodoRepository>();
builder.Services.AddTransient<ITodoItemService, TodoItemService>();
//builder.Services.AddTransient<ITodoService, TodoItemService>();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
