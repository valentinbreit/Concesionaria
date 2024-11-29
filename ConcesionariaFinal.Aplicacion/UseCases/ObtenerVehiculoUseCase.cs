using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;

namespace ConcesionariaFinal.Aplicacion.UseCases;

public class ObtenerVehiculoUseCase : VehiculoUseCase
{
    public ObtenerVehiculoUseCase(IRepositorioVehiculo repositorio) : base(repositorio)
    {
    }

    public Vehiculo? Ejecutar(int id)
    {
        return Repositorio.ObtenerVehiculo(id);
    }
}