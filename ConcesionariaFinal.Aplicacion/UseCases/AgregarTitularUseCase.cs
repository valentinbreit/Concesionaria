using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;
namespace ConcesionariaFinal.Aplicacion.UseCases;

public class AgregarTitularUseCase : TitularUseCase
{
public AgregarTitularUseCase(IRepositorioTitular repositorio) : base(repositorio)
{
}

public void Ejecutar(Titular titular)
    {
        Repositorio.AgregarTitular(titular);
    }
}