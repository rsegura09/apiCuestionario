using apiCuestionario;
using apiCuestionario.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSqlServer<CuestionarioContext>(builder.Configuration.GetConnectionString("cuestionarioDiego"));

builder.Services.AddScoped<ICuestionarioService, CuestionarioService>();

builder.Services.AddScoped<IPersonaService, PersonaService>();

builder.Services.AddScoped<IPreguntaService, PreguntaService>();

builder.Services.AddScoped<IRespuestaService, RespuestaService>();

builder.Services.AddScoped<IRespuestaUsuarioService, RespuestaUsuarioService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("Nueva politica", app =>
    {
        app.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
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

app.MapControllers();

app.UseCors("Nueva politica");

app.Run();
