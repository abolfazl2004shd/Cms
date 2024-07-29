using Cms.Data.Context;
using Cms.Data.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMvc();
#region Add Services

#endregion
builder.Services.AddScoped<IArticleCommentService, ArticleCommentService>();
builder.Services.AddScoped<IArticleService, ArticleService>();
builder.Services.AddScoped<IArticleGroupService, ArticleGroupService>();

#region DataBase Context
string ConnectionString = "CmsContextConnection";
builder.Services.AddDbContext<CmsDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration[$"ConnectionStrings:{ConnectionString}"]);
});
#endregion

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
