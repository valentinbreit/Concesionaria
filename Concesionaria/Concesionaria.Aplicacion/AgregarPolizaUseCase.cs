namespace Concesionaria.Aplicacion;
public class AgregarPolizaUseCase {
   private readonly IRepositorioPoliza repositorio;
   public AgregarPolizaUseCase (IRepositorioPoliza r){
    this.repositorio= r;
   }
    public void Ejecutar (Poliza p){
        repositorio.AgregarPoliza (p);
    }
}