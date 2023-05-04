namespace Concesionaria.Aplicacion;
public class ModificarVehiculoUseCase {
   private readonly IRepositorioVehiculo repositorio;
   public ModificarVehiculoUseCase (IRepositorioVehiculo r){
    this.repositorio= r;
   }
    public void Ejecutar (Vehiculo v){
        repositorio.ModificarVehiculo (v);
    }
}