namespace Concesionaria.Aplicacion;
public class ModificarPolizaUseCase{
    private readonly IRepositorioPoliza repositorio;
    public ModificarPolizaUseCase(IRepositorioPoliza r){
    this.repositorio= r;
   }
     public void Ejecutar (Poliza p){
        repositorio.ModificarPoliza (p); 
    }
}



