namespace Concesionaria.Aplicacion;
public interface IRepositorioVehiculo{
    void AgregarVehiculo (Vehiculo v);
    void EliminarVehiculo (int Id);
    void ModificarVehiculo(Vehiculo v);
    List<Vehiculo> ListarVehiculos ();
}