var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Use(async (context,next) =>
{
    await context.Response.WriteAsync("Welcome to ASP.NET Core tutorial \n");
    await next(context);
});

app.Use(async (context,next) =>
{
    await context.Response.WriteAsync("This is Ashish Senapati");
    await next(context);
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("End of middleware pipeline");
});

app.Run();
