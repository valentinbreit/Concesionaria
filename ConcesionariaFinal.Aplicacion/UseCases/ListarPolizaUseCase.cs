using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;

namespace ConcesionariaFinal.Aplicacion.UseCases;

public class ListarPolizaUseCase : PolizaUseCase
{
public ListarPolizaUseCase(IRepositorioPoliza repositorio) : base(repositorio)
{
}

public List<Poliza> Ejecutar()
{
return Repositorio.ListarPolizas();
}
}