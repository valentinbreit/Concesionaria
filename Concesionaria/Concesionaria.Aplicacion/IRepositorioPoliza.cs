namespace Concesionaria.Aplicacion;
public interface IRepositorioPoliza{
    void AgregarPoliza (Poliza p);
    void EliminarPoliza (int Id);
    void ModificarPoliza (Poliza p);
    List<Poliza> ListarPolizas ();
}