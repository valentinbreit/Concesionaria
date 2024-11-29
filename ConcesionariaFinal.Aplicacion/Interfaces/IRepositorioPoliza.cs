namespace ConcesionariaFinal.Aplicacion.Interfaces;
using ConcesionariaFinal.Aplicacion.Entidades;
public interface IRepositorioPoliza{
    void AgregarPoliza (Poliza p);
    void EliminarPoliza (int Id);
    void ModificarPoliza (Poliza p);
    Poliza? ObtenerPoliza(int Id);
    List<Poliza> ListarPolizas ();
}