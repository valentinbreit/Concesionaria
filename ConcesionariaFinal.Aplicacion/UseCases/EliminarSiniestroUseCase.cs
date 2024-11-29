using ConcesionariaFinal.Aplicacion.Interfaces;

namespace ConcesionariaFinal.Aplicacion.UseCases;

public class EliminarSiniestroUseCase : SiniestroUseCase
    {
    public EliminarSiniestroUseCase(IRepositorioSiniestro repositorio) : base(repositorio)
    {
    }
    public void Ejecutar(int id)
    {
        Repositorio.EliminarSiniestro(id);
    }
}