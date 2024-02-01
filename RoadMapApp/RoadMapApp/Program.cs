global using Microsoft.EntityFrameworkCore;
using Lamar.Microsoft.DependencyInjection;
using RoadMapApp.Data;
using RoadMapApp;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLamar();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Host.UseLamar((_, registry) => registry.InjectServices().InjectRepositories());

builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

// UseSqlServer
// builder.Services.AddDbContext<DataContext>(
//         options=>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// UseMySql
const string connectionString = "server=localhost;user=root;password=;database=roamdapdb";
builder.Services.AddDbContext<DataContext>(
    options => options.UseMySql(
        connectionString,
        new MySqlServerVersion(new Version(8, 0, 29)))
);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        policyBuilder => policyBuilder
            .AllowAnyMethod()
            .AllowCredentials()
            .WithOrigins("http://localhost:3000")
            .AllowAnyHeader());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();
