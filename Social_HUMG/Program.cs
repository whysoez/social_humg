using AutoMapper;
using Social_HUMG.Common;
using Social_HUMG.Data;
using Social_HUMG.Repository.IReprositoryServives;
using Social_HUMG.Repository.RepositoryServices;
using Social_HUMG.Services.IServices;
using Social_HUMG.Services.ServicesImplement;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddDbContext<SocialDbContext>(options =>
{
    builder.Services.AddScoped<SocialDbContext>(sp =>
        sp.GetRequiredService<SocialDbContext>());
    builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepositoryServices<>));
});
builder.Services.AddScoped<IEmployeeRepositoryServices, EmployeeRepositoryServices>();
builder.Services.AddScoped<IEmployeeServices, EmployeeServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
