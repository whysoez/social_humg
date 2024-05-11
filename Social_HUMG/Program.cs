using AutoMapper;
using Social_HUMG.Common;
using Social_HUMG.Data;
using Social_HUMG.DI;
using Social_HUMG.Repository.IReprositoryServives;
using Social_HUMG.Repository.RepositoryServices;
using Social_HUMG.Services.IServices;
using Social_HUMG.Services.ServicesImplement;
using Social_HUMG.SignalR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//builder.Services.AddCors(o => o.AddPolicy("CorsPolicy", b =>
//{
//    b.AllowAnyMethod()
//    .AllowAnyHeader()
//    .AllowAnyOrigin();
//}));
builder.Services.AddSignalR(options => { options.KeepAliveInterval = TimeSpan.FromSeconds(5); }).AddMessagePackProtocol();

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
builder.Services.AddScoped<IGroupRepositoryServices, GroupRepositoryServices>();
builder.Services.AddScoped<IPostRepositoryServices, PostRepositoryServices>();
builder.Services.AddScoped<IEmployeeServices, EmployeeServices>();
builder.Services.AddScoped<IGroupServices, GroupServices>();
builder.Services.AddScoped<IPostServices, PostServices>();
//builder.Services.AddMyDenpendencyRepositoryServicesGroup()
//    .AddMyDenpendencyServicesGroup();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseCors("CorsPolicy");
app.UseRouting();
app.UseEndpoints(enpoints => enpoints.MapHub<SignalrHub>("/signalr"));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
