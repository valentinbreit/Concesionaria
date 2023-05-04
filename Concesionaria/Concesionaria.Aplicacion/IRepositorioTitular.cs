namespace Concesionaria.Aplicacion;
public interface IRepositorioTitular{
    void AgregarTitular (Titular t);
    void EliminarTitular (int Id);
    void ModificarTitular(Titular t); //preguntar
    List<Titular> ListarTitulares ();
}