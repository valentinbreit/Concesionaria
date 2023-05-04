namespace Concesionaria.Aplicacion;
public class ListarTitularesUseCase{
    private readonly IRepositorioTitular repositorio;
    public ListarTitularesUseCase(IRepositorioTitular r){
    this.repositorio= r;
   }
     public List<Titular> Ejecutar() {
        return repositorio.ListarTitulares(); 
    }
}