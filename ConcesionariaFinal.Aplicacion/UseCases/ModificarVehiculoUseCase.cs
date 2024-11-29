using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;

namespace ConcesionariaFinal.Aplicacion.UseCases;

public class ModificarVehiculoUseCase : VehiculoUseCase
{
    public ModificarVehiculoUseCase(IRepositorioVehiculo repositorio) : base(repositorio)
    {
    }

    public void Ejecutar(Vehiculo Vehiculo)
    {
        Repositorio.ModificarVehiculo(Vehiculo);
    }
}