using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;

namespace ConcesionariaFinal.Aplicacion.UseCases;

public class ListarVehiculoUseCase : VehiculoUseCase
{
public ListarVehiculoUseCase(IRepositorioVehiculo repositorio) : base(repositorio)
{
}

public List<Vehiculo> Ejecutar()
{
return Repositorio.ListarVehiculos();
}
}