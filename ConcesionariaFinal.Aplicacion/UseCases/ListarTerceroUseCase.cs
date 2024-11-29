using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;

namespace ConcesionariaFinal.Aplicacion.UseCases;

public class ListarTerceroUseCase : TerceroUseCase
{
public ListarTerceroUseCase(IRepositorioTercero repositorio) : base(repositorio)
{
}

public List<Tercero> Ejecutar()
{
return Repositorio.ListarTerceros();
}
}