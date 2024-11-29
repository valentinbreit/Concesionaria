using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;

namespace ConcesionariaFinal.Aplicacion.UseCases;

public class ModificarTerceroUseCase : TerceroUseCase
{
    public ModificarTerceroUseCase(IRepositorioTercero repositorio) : base(repositorio)
    {
    }

    public void Ejecutar(Tercero Tercero)
    {
        Repositorio.ModificarTercero(Tercero);
    }
}