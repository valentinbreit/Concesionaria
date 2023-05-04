namespace Concesionaria.Aplicacion;
public class EliminarVehiculoUseCase{
    private readonly IRepositorioVehiculo repositorio;
    public EliminarVehiculoUseCase(IRepositorioVehiculo r){
    this.repositorio= r;
   }
     public void Ejecutar (int id){
        repositorio.EliminarVehiculo (id);
    }
}