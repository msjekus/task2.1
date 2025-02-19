using System.Text;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async context =>
{
    var index = await File.ReadAllTextAsync("html/index.html");
    context.Response.ContentType = "text/html;charset=utf-8\"";
    await context.Response.WriteAsync(index);
});

app.MapGet("/bio", async context =>
{
    var html = await File.ReadAllTextAsync("html/bio.html");
    context.Response.ContentType = "text/html;charset=utf-8\"";
    await context.Response.WriteAsync(html);
});

app.MapGet("/portfolio", async context =>
{
    var html = await File.ReadAllTextAsync("html/portfolio.html");
    context.Response.ContentType = "text/html;charset=utf-8\"";
    await context.Response.WriteAsync(html);
});

app.Run();
