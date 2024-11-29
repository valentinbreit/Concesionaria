using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;

namespace ConcesionariaFinal.Aplicacion.UseCases;

public class ModificarSiniestroUseCase : SiniestroUseCase
{
    public ModificarSiniestroUseCase(IRepositorioSiniestro repositorio) : base(repositorio)
    {
    }

    public void Ejecutar(Siniestro Siniestro)
    {
        Repositorio.ModificarSiniestro(Siniestro);
    }
}