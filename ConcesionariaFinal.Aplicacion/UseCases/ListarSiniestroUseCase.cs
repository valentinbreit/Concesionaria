using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;

namespace ConcesionariaFinal.Aplicacion.UseCases;

public class ListarSiniestroUseCase : SiniestroUseCase
{
public ListarSiniestroUseCase(IRepositorioSiniestro repositorio) : base(repositorio)
{
}

public List<Siniestro> Ejecutar()
{
return Repositorio.ListarSiniestros();
}
}