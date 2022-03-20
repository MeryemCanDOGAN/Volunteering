using FluentValidation.AspNetCore;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.AspNetCore.Mvc;
using volunteer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ILoginService,LoginService>();
builder.Services.AddScoped<VolunteerContext>();
builder.Services.AddScoped<IAccountRepository,AccountRepository>();
builder.Services.AddScoped<IAccountService,AccountService>();
builder.Services.AddScoped<IUserRepository,UserRepository>();
builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddScoped<IAddressRepository,AddressRepository>();
builder.Services.AddScoped<IAddressService,AddressService>();
builder.Services.AddScoped<IAnnouncementRepository,AnnouncementRepository>();
builder.Services.AddScoped<IAnnouncementService,AnnouncementService>();
builder.Services.AddScoped<ICoatSizeRepository,CoatSizeRepository>();
builder.Services.AddScoped<ICoatSizeService,CoatSizeService>();
builder.Services.AddScoped<IHatScarfGloveSizeRepository,HatScarfGloveSizeRepository>();
builder.Services.AddScoped<IHatScarfGloveSizeService,HatScarfGloveSizeService>();
builder.Services.AddScoped<ISchoolRepository,SchoolRepository>();
builder.Services.AddScoped<ISchoolService,SchoolService>();
builder.Services.AddScoped<IShoesSizeRepository,ShoesSizeRepository>();
builder.Services.AddScoped<IShoesSizeService,ShoesSizeService>();
builder.Services.AddScoped<IStationeryEquipmentListRepository,StationeryEquipmentListRepository>();
builder.Services.AddScoped<IStationeryEquipmentListService,StationeryEquipmentListService>();
builder.Services.AddScoped<ITeacherRepository,TeacherRepository>();
builder.Services.AddScoped<ITeacherService,TeacherService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<JwtMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
