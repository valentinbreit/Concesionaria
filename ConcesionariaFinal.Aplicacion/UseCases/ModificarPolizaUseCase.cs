using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;

namespace ConcesionariaFinal.Aplicacion.UseCases;

public class ModificarPolizaUseCase : PolizaUseCase
{
    public ModificarPolizaUseCase(IRepositorioPoliza repositorio) : base(repositorio)
    {
    }

    public void Ejecutar(Poliza Poliza)
    {
        Repositorio.ModificarPoliza(Poliza);
    }
}