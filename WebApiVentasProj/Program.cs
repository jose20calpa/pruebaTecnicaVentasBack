


using Core.Contratos;
using Infraestructura.Repositorios;
using Servicio.Servicios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IClienteServicio, ClienteServicio>();
builder.Services.AddTransient<IProductoServicio, ProductoServicio>();
builder.Services.AddTransient<IVentaServicio, VentaServicio>();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<IProductoRepository, ProductoRepository>();
builder.Services.AddTransient<IVentaRepository, VentaRepository>();

builder.Services.AddCors(X =>
{
    X.AddPolicy("AllowOrigin", options => options.SetIsOriginAllowed(isOriginAllowed: _ => true).AllowAnyMethod().AllowAnyHeader().AllowCredentials());
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

app.UseCors("AllowOrigin");
app.UseAuthorization();

app.MapControllers();

app.Run();
