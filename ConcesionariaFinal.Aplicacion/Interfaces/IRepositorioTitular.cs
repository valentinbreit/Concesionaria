namespace ConcesionariaFinal.Aplicacion.Interfaces;
using ConcesionariaFinal.Aplicacion.Entidades;
public interface IRepositorioTitular{
    void AgregarTitular (Titular t);
    void EliminarTitular (int Id);
    void ModificarTitular(Titular t);
    List<Titular> ListarTitulares ();
    List<Titular> ListarTitularesConSusVehiculos();
    Titular? ObtenerTitular(int Id);
}