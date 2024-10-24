using Microsoft.EntityFrameworkCore;
using webapp_sample.Data; 
var builder = WebApplication.CreateBuilder(args);
// Ensure this matches your namespace for ApplicationDbContext


// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddControllersWithViews(); 
// Add the DbContext with SQL Server connection string
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

    
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

 // This will work after installing the package




app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
