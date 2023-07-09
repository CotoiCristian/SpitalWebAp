using Habanero.Util;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using ServiceStack;
using SpitalFinal.Models;
using SpitalFinal.Repositories;
using SpitalFinal.Repositories.Interfaces;
using SpitalFinal.Services;
using SpitalFinal.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using SendGrid;
using Microsoft.AspNetCore.Identity.UI.Services;
using SpitalFinal.Areas.Identity.Pages.Account.Manage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Logging.AddConsole();
builder.Services.AddDbContext<SpitalContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SpitalFinalDb")));
builder.Services.AddTransient<IEmailSender>(serviceProvider =>
{
    var sendGridApiKey = "YOUR_SENDGRID_API_KEY"; // înlocuiește cu cheia ta API SendGrid
    return new SendGridEmailSender(sendGridApiKey);
});

builder.Services.AddRazorPages();

builder.Services.Configure<IdentityOptions>(options =>
{
    // Password settings
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 8;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = true;
    options.Password.RequireLowercase = false;
    options.Password.RequiredUniqueChars = 6;

    // Lockout settings
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
    options.Lockout.MaxFailedAccessAttempts = 10;
    options.Lockout.AllowedForNewUsers = true;

    // User Settings
    options.User.RequireUniqueEmail = true;
});

// Register services and repositories
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
        .AddDefaultTokenProviders()
        .AddEntityFrameworkStores<SpitalContext>();

builder.Services.AddScoped<IFisaMedicRepository, FisaMedicRepository>();
builder.Services.AddScoped<IFisaMedicService, FisaMedicalaService>(); 

builder.Services.AddScoped<IInvestigatieRepository, InvestigatieRepository>();
builder.Services.AddScoped<IInvestigatieService, InvestigatieService>();

builder.Services.AddScoped<IMedicRepository, MedicRepository>();
builder.Services.AddScoped<IMedicService, MedicService>();

builder.Services.AddScoped<IPacientRepository, PacientRepository>();
builder.Services.AddScoped<IPacientService, PacientService>();

builder.Services.AddScoped<IProgramareRepository, ProgramareRepository>();
builder.Services.AddScoped<IProgramareService, ProgramareService>();

builder.Services.AddScoped<IProgramLucruRepository, ProgramLucruRepository>();
builder.Services.AddScoped<IProgramLucruService, ProgramLucruService>();

builder.Services.AddScoped<IRetetaMedicalaRepository, RetetaMedicalaRepository>();
builder.Services.AddScoped<IRetetaMedicalaService, RetetaMedicalaService>();

builder.Services.AddScoped<ISectieRepository, SectieRepository>();
builder.Services.AddScoped<ISectieService, SectieService>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IIdentityUserService, IdentityUserService>();



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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
