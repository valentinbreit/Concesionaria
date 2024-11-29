namespace ConcesionariaFinal.Aplicacion.Interfaces;
using ConcesionariaFinal.Aplicacion.Entidades;
public interface IRepositorioSiniestro{
    void AgregarSiniestro (Siniestro s);
    void EliminarSiniestro (int Id);
    void ModificarSiniestro(Siniestro s); //preguntar
    Siniestro? ObtenerSiniestro(int Id);
    List<Siniestro> ListarSiniestros ();
}