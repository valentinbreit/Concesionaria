namespace Concesionaria.Aplicacion;
public class EliminarTitularUseCase{
    private readonly IRepositorioTitular repositorio;
    public EliminarTitularUseCase(IRepositorioTitular r){
    this.repositorio= r;
   }
     public void Ejecutar (int id){
        repositorio.EliminarTitular (id);
    }
}