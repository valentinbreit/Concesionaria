using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;
namespace ConcesionariaFinal.Aplicacion.UseCases;

public class AgregarPolizaUseCase : PolizaUseCase
{
    IRepositorioVehiculo repoV; 
    public AgregarPolizaUseCase(IRepositorioPoliza repositorioP, IRepositorioVehiculo repositorioV) : base(repositorioP)
    {
        repoV = repositorioV;
    }

    public void Ejecutar(Poliza poliza)
    {
        var v = repoV.ObtenerVehiculo(poliza.VehiculoId);
        if (v != null){
            Repositorio.AgregarPoliza(poliza);
        }
        else
        {
            throw new Exception ($"No existe vehiculo con Id: {poliza.VehiculoId}");
        }
    }
}