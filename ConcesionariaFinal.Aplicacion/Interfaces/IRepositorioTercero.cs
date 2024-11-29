namespace ConcesionariaFinal.Aplicacion.Interfaces;
using ConcesionariaFinal.Aplicacion.Entidades;
public interface IRepositorioTercero {
    void AgregarTercero (Tercero t);
    void EliminarTercero (int Id);
    void ModificarTercero (Tercero t); //preguntar
    List<Tercero> ListarTerceros ();
    Tercero? ObtenerTercero(int Id);
}