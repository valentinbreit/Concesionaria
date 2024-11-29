using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;

namespace ConcesionariaFinal.Aplicacion.UseCases;

public class ObtenerPolizaUseCase : PolizaUseCase
{
    public ObtenerPolizaUseCase(IRepositorioPoliza repositorio) : base(repositorio)
    {
    }

    public Poliza? Ejecutar(int id)
    {
        return Repositorio.ObtenerPoliza(id);
    }
}