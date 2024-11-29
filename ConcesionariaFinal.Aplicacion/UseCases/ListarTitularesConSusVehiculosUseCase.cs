using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;

namespace ConcesionariaFinal.Aplicacion.UseCases;

public class ListarTitularesConSusVehiculosUseCase : TitularUseCase
{
    public ListarTitularesConSusVehiculosUseCase(IRepositorioTitular repositorio) : base(repositorio)
    {
    }

    public List<Titular> Ejecutar()
    {
        return Repositorio.ListarTitularesConSusVehiculos();
    }
}