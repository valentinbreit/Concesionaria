using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;
namespace ConcesionariaFinal.Aplicacion.UseCases;

public class AgregarTerceroUseCase : TerceroUseCase
{
    IRepositorioSiniestro repoS; 
    public AgregarTerceroUseCase(IRepositorioTercero repositorioT, IRepositorioSiniestro repositorioS) : base(repositorioT)
    {
        repoS = repositorioS;
    }


    public void Ejecutar(Tercero tercero)
    {
        var t = repoS.ObtenerSiniestro(tercero.SiniestroId);
        if (t != null){
            Repositorio.AgregarTercero(tercero);
        }
        else
        {
            throw new Exception ($"No existe sieniestro con Id: {tercero.SiniestroId}");
        }
    }
}