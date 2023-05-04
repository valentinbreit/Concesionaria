namespace Concesionaria.Aplicacion;
public class AgregarVehiculoUseCase {
   private readonly IRepositorioVehiculo repositorio;
   public AgregarVehiculoUseCase (IRepositorioVehiculo r){
    this.repositorio= r;
   }
    public void Ejecutar (Vehiculo v){
        repositorio.AgregarVehiculo (v);
    }
}