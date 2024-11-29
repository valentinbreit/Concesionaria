using ConcesionariaFinal.Aplicacion.Interfaces;

namespace ConcesionariaFinal.Aplicacion.UseCases;

public abstract class TerceroUseCase
{
protected IRepositorioTercero Repositorio { get; private set; }

public TerceroUseCase(IRepositorioTercero repositorio)
{
this.Repositorio = repositorio;
}
}