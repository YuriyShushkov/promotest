using Microsoft.EntityFrameworkCore;
using PromoTest.Server.Contracts.Services;
using PromoTest.Server.Services;
using PromoTest.Server.Storage;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors();
builder.Services.AddDbContext<ApplicationContext>(options => ConfigureDbContext(options, ApplicationContext.ConnectionString));
builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddScoped<IProvinceService, ProvinceService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddAutoMapper(typeof(AppMappingProfile));

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();
app.UseCors(options =>
    options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();

static DbContextOptionsBuilder ConfigureDbContext(DbContextOptionsBuilder options, string connectionString) => options
    .EnableSensitiveDataLogging()
    .UseNpgsql(connectionString, b => b.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName));
