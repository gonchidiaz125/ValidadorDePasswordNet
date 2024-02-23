var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureSwaggerGen(setup =>
{
    setup.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Validacion de Password",
        Version = "v1"
    });
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirSoloMiAplicacion", builder =>
    {                                                     
        builder.WithOrigins("http://127.0.0.1:5500", "https://lemon-plant-09c183a0f.4.azurestaticapps.net")
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

app.UseCors("PermitirSoloMiAplicacion");

app.UseSwagger();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{    
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
