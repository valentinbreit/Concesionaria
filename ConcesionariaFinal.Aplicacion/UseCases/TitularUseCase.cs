using ConcesionariaFinal.Aplicacion.Interfaces;

namespace ConcesionariaFinal.Aplicacion.UseCases;

    public abstract class TitularUseCase
    {
    protected IRepositorioTitular Repositorio { get; private set; }

    public TitularUseCase(IRepositorioTitular repositorio)
    {
        this.Repositorio = repositorio;
    }
}