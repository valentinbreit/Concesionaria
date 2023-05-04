namespace Concesionaria.Aplicacion;
public class ListarVehiculosUseCase{
    private readonly IRepositorioVehiculo repositorio;
    public ListarVehiculosUseCase(IRepositorioVehiculo r){
    this.repositorio= r;
   }
     public List<Vehiculo> Ejecutar() {
        return repositorio.ListarVehiculos(); 
    }
}