namespace Concesionaria.Aplicacion;
public class EliminarPolizaUseCase{
    private readonly IRepositorioPoliza repositorio;
    public EliminarPolizaUseCase(IRepositorioPoliza r){
    this.repositorio= r;
   }
     public void Ejecutar (int id){
        repositorio.EliminarPoliza (id);
    }
}