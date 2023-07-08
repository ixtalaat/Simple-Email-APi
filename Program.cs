using Microsoft.Extensions.DependencyInjection;
using SimpleEmailApp.Services;
using SimpleEmailApp.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var emailConfig = builder.Configuration
		.GetSection("MailSettings")
		.Get<MailSettings>();
builder.Services.AddSingleton(emailConfig);

builder.Services.AddTransient<IMailingService, MailingService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
