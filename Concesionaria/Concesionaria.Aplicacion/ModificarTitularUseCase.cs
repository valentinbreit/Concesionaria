namespace Concesionaria.Aplicacion;
public class ModificarTitularUseCase{
    private readonly IRepositorioTitular repositorio;
    public ModificarTitularUseCase(IRepositorioTitular r){
    this.repositorio= r;
   }
     public void Ejecutar (Titular t){
        repositorio.ModificarTitular (t); 
    }
}