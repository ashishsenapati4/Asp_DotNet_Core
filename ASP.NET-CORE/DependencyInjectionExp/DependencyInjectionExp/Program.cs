using DependencyInjectionExp.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();

//Add Application services to the container 
//builder.Services.Add(new ServiceDescriptor(typeof(IStudentRepository), typeof(StudentRepository)));//by default Singleton
//builder.Services.Add(new ServiceDescriptor(typeof(IStudentRepository), typeof(StudentRepository),ServiceLifetime.Singleton));// Singleton
//builder.Services.Add(new ServiceDescriptor(typeof(IStudentRepository), typeof (StudentRepository),ServiceLifetime.Transient));//Transient
//builder.Services.Add(new ServiceDescriptor(typeof(IStudentRepository), typeof(StudentRepository),ServiceLifetime.Scoped));//Scoped

//We can register services using extension methods
builder.Services.AddSingleton<IStudentRepository, StudentRepository>();
//builder.Services.AddTransient<IStudentRepository, StudentRepository>();
//builder.Services.AddScoped<IStudentRepository, StudentRepository>();

var app = builder.Build();

app.UseRouting();

app.MapControllerRoute(
    name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
