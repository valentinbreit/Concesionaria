using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;

namespace ConcesionariaFinal.Aplicacion.UseCases;

public class ObtenerTerceroUseCase : TerceroUseCase
{
    public ObtenerTerceroUseCase(IRepositorioTercero repositorio) : base(repositorio)
    {
    }

    public Tercero? Ejecutar(int id)
    {
        return Repositorio.ObtenerTercero(id);
    }
}