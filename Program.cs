using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AndresGuaman_Examen1PROG.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AndresGuaman_Examen1PROGContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AndresGuaman_Examen1PROGContext") ?? throw new InvalidOperationException("Connection string 'AndresGuaman_Examen1PROGContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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

app.Run();
