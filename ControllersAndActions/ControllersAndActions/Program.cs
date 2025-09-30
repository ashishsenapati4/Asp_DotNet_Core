var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{Controller=Home}/{Action=Index}/{id?}"
//    );

//app.MapGet("/", () => "Hello World!");

app.MapControllers();

app.Run();
