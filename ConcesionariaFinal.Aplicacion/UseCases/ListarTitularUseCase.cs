using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;

namespace ConcesionariaFinal.Aplicacion.UseCases;

public class ListarTitularUseCase : TitularUseCase
{
public ListarTitularUseCase(IRepositorioTitular repositorio) : base(repositorio)
{
}

public List<Titular> Ejecutar()
{
return Repositorio.ListarTitulares();
}
}