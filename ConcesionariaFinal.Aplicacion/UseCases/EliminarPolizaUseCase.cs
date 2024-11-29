using ConcesionariaFinal.Aplicacion.Interfaces;

namespace ConcesionariaFinal.Aplicacion.UseCases;

public class EliminarPolizaUseCase : PolizaUseCase
{
public EliminarPolizaUseCase(IRepositorioPoliza repositorio) : base(repositorio)
{
}
public void Ejecutar(int id)
{
Repositorio.EliminarPoliza(id);
}
}