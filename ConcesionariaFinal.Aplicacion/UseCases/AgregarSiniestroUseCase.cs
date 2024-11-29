using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;
namespace ConcesionariaFinal.Aplicacion.UseCases;

public class AgregarSiniestroUseCase : SiniestroUseCase
{
    IRepositorioPoliza repoP; 
    public AgregarSiniestroUseCase(IRepositorioSiniestro repositorioS, IRepositorioPoliza repositorioP) : base(repositorioS)
    {
        repoP = repositorioP;
    }

    public void Ejecutar(Siniestro siniestro)
    {
        var p = repoP.ObtenerPoliza(siniestro.PolizaId);
        if (p != null) {
            if (siniestro.FechaOcurrencia < DateTime.Now){
                if ((p.FechaInicio < siniestro.FechaOcurrencia) & (siniestro.FechaOcurrencia < p.FechaFin)){
                    Repositorio.AgregarSiniestro(siniestro);
                }
                else
                {
                    throw new Exception ("La fecha de ocurrencia del siniestro se encuentra fuera del rango de la poliza.");
                }
            }
            else
            {
                throw new Exception ("La fecha de ocurrencia no es valida.");
            }
        }
        else
        {
            throw new Exception ($"No existe la poliza con Id: {siniestro.PolizaId}.");
        }
    }
}