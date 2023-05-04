namespace Concesionaria.Aplicacion;
public class ListarPolizaUseCase{
    private readonly IRepositorioPoliza repositorio;
    public ListarPolizaUseCase(IRepositorioPoliza r){
    this.repositorio= r;
   }
     public List<Poliza> Ejecutar() {
         return repositorio.ListarPolizas (); 
    }
}