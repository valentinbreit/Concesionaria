namespace ConcesionariaFinal.Aplicacion.Interfaces;
using ConcesionariaFinal.Aplicacion.Entidades;
public interface IRepositorioVehiculo{
    void AgregarVehiculo (Vehiculo v);
    void EliminarVehiculo (int id);
    void ModificarVehiculo(Vehiculo v);
    Vehiculo? ObtenerVehiculo(int id);
    List<Vehiculo> ListarVehiculos ();
}