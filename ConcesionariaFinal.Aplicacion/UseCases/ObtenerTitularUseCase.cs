using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;

namespace ConcesionariaFinal.Aplicacion.UseCases;

public class ObtenerTitularUseCase : TitularUseCase
{
    public ObtenerTitularUseCase(IRepositorioTitular repositorio) : base(repositorio)
    {
    }

    public Titular? Ejecutar(int id)
    {
        return Repositorio.ObtenerTitular(id);
    }
}