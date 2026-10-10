
using MicroBlog.Services;
using MicroBlog.Repositories;
using MicroBlog.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.Configure<SiteOptions>(
    builder.Configuration.GetSection("SiteOptions"));

builder.Services.AddSingleton<PostService>();
builder.Services.AddSingleton<IBlogRepository, JsonBlogRepository>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();