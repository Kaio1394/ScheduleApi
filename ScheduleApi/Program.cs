using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ScheduleApi.Data;
using ScheduleApi.Model.User;
using Serilog;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System;
using System.Text;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ScheduleApi.Controllers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ScheduleApiDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionStrings"))
    .ConfigureWarnings(warnings =>
               warnings.Ignore(RelationalEventId.PendingModelChangesWarning)));

builder.Services.AddIdentity<ApiUser, IdentityRole>()
    .AddEntityFrameworkStores<ScheduleApiDbContext>()
    .AddDefaultTokenProviders();

builder.Logging.ClearProviders();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Host.UseSerilog((ctx, lc) =>
{
    lc.WriteTo.Console().ReadFrom.Configuration(ctx.Configuration);
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", b =>
    {
        b.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
    });
});

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
        ValidAudience = builder.Configuration["JwtSettings:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:Key"]))
    };
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
