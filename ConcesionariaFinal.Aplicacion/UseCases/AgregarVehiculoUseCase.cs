using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;
namespace ConcesionariaFinal.Aplicacion.UseCases;

public class AgregarVehiculoUseCase : VehiculoUseCase
{
    IRepositorioTitular repoT; 
    public AgregarVehiculoUseCase(IRepositorioVehiculo repositorioV, IRepositorioTitular repositorioT) : base(repositorioV)
    {
        repoT = repositorioT;
    }

    public void Ejecutar(Vehiculo vehiculo)
    {
        var t = repoT.ObtenerTitular(vehiculo.TitularId);
        if (t != null){
            Repositorio.AgregarVehiculo(vehiculo);
        }
        else
        {
            throw new Exception ($"No existe titular con Id: {vehiculo.TitularId}");
        }
    }
}