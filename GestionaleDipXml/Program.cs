using FluentAssertions.Common;
using GestionaleDipXml.Data;
using GestionaleDipXml.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//var builderTwo= WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<DipendentiDbConext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("gestionale_dipendenti") ?? throw new InvalidOperationException("Connection string 'WebApplication1Context' not found.")));


builder.Services.AddDbContext<TestXmlContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("TestXml") ?? throw new InvalidOperationException("Connection string 'WebApplication1Context' not found.")));





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
