using businesslayer.Abstract;
using businesslayer.concrete;
using dataaccesslayer.asbtract;
using dataaccesslayer.concrete;
using dataaccesslayer.entityframework;
using entitylayer.concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<context>();

builder.Services.AddIdentity<WriterUser, WriterRole>()
    .AddEntityFrameworkStores<context>()    
    .AddDefaultTokenProviders();
   
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IToDoListDal, EFToDoListDal>();
builder.Services.AddScoped<IToDoListService, ToDoListManager>();

builder.Services.AddScoped<Iexperiencedal, efexperiencedal>();
builder.Services.AddScoped<IExperienceService, ExperienceManager>();

builder.Services.AddScoped<Iportfoliodal, efportfoliodal>();
builder.Services.AddScoped<Iportfolioservice, PortfolioManager>();

builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser()
    .Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.AddMvc();
//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
//    .AddCookie(x =>
//    {
//        x.LoginPath = "/Writer/Login/Index/";
//    });

builder.Services.ConfigureApplicationCookie(option =>
{
    option.Cookie.HttpOnly = true;
    option.ExpireTimeSpan = TimeSpan.FromMinutes(300);
    option.AccessDeniedPath = "/ErrorPage/Index/";
    option.LoginPath = "/Writer/Login/Index/";

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404/");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Default}/{action=Index}/{id?}"
    );
});

app.Run();
