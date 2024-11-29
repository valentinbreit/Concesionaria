using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;

namespace ConcesionariaFinal.Aplicacion.UseCases;

public class ObtenerSiniestroUseCase : SiniestroUseCase
{
    public ObtenerSiniestroUseCase(IRepositorioSiniestro repositorio) : base(repositorio)
    {
    }

    public Siniestro? Ejecutar(int id)
    {
        return Repositorio.ObtenerSiniestro(id);
    }
}