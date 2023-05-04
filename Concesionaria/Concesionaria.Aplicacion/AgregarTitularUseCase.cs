namespace Concesionaria.Aplicacion;
public class AgregarTitularUseCase {
   private readonly IRepositorioTitular repositorio;
   public AgregarTitularUseCase (IRepositorioTitular r){
    this.repositorio= r;
   }
    public void Ejecutar (Titular t){
        repositorio.AgregarTitular (t);
    }
}