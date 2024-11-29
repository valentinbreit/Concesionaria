using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;
using ConcesionariaFinal.Aplicacion.UseCases;
using ConcesionariaFinal.Repositorios;
using ConcesionariaFinal;

using (var context = new ConcesionariaFinalContext())
{
    context.Database.EnsureCreated();
}

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//agregamos estos servicios al contenedor DI
builder.Services.AddTransient<AgregarTitularUseCase>();
builder.Services.AddTransient<ListarTitularUseCase>();
builder.Services.AddTransient<EliminarTitularUseCase>();
builder.Services.AddTransient<ModificarTitularUseCase>();
builder.Services.AddTransient<ObtenerTitularUseCase>();
builder.Services.AddScoped<IRepositorioTitular, RepositorioTitular>();

builder.Services.AddTransient<AgregarVehiculoUseCase>();
builder.Services.AddTransient<ListarVehiculoUseCase>();
builder.Services.AddTransient<EliminarVehiculoUseCase>();
builder.Services.AddTransient<ModificarVehiculoUseCase>();
builder.Services.AddTransient<ObtenerVehiculoUseCase>();
builder.Services.AddScoped<IRepositorioVehiculo, RepositorioVehiculo>();

builder.Services.AddTransient<AgregarPolizaUseCase>();
builder.Services.AddTransient<ListarPolizaUseCase>();
builder.Services.AddTransient<EliminarPolizaUseCase>();
builder.Services.AddTransient<ModificarPolizaUseCase>();
builder.Services.AddTransient<ObtenerPolizaUseCase>();
builder.Services.AddScoped<IRepositorioPoliza, RepositorioPoliza>();

builder.Services.AddTransient<AgregarSiniestroUseCase>();
builder.Services.AddTransient<ListarSiniestroUseCase>();
builder.Services.AddTransient<EliminarSiniestroUseCase>();
builder.Services.AddTransient<ModificarSiniestroUseCase>();
builder.Services.AddTransient<ObtenerSiniestroUseCase>();
builder.Services.AddScoped<IRepositorioSiniestro, RepositorioSiniestro>();

builder.Services.AddTransient<AgregarTerceroUseCase>();
builder.Services.AddTransient<ListarTerceroUseCase>();
builder.Services.AddTransient<EliminarTerceroUseCase>();
builder.Services.AddTransient<ModificarTerceroUseCase>();
builder.Services.AddTransient<ObtenerTerceroUseCase>();
builder.Services.AddScoped<IRepositorioTercero, RepositorioTercero>();


builder.Services.AddTransient<ListarTitularesConSusVehiculosUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
