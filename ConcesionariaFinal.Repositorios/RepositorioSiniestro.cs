using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;
namespace ConcesionariaFinal.Repositorios;

public class RepositorioSiniestro : IRepositorioSiniestro
{
    public void AgregarSiniestro (Siniestro s)
    {
        using (var context = new ConcesionariaFinalContext())
        {
            context.Siniestro.Add(s);
            context.SaveChanges();
        }
    }
    public void EliminarSiniestro (int Id)
    {
        using (var context = new ConcesionariaFinalContext())
        {
            var siniestroBorrar = context.Siniestro.Where(s=> s.Id == Id).SingleOrDefault();
            if (siniestroBorrar !=null)
            {
                context.Siniestro.Remove(siniestroBorrar);
            }
            context.SaveChanges();
        }
    }
    public void ModificarSiniestro(Siniestro s)
    {
        using (var context = new ConcesionariaFinalContext())
        {
            var siniestroModificar = context.Siniestro.Where(siniestro=> siniestro.Id == s.Id).SingleOrDefault();
            if (siniestroModificar !=null)
            {
                siniestroModificar.Id=s.Id;
                siniestroModificar.PolizaId= s.PolizaId;
                siniestroModificar.FechaIngreso=s.FechaIngreso;
                siniestroModificar.FechaOcurrencia=s.FechaOcurrencia;
                siniestroModificar.Direccion=s.Direccion;
                siniestroModificar.Descripcion=s.Descripcion;
                siniestroModificar.Terceros=s.Terceros;  
            }
            context.SaveChanges();
        }
    }
    public List<Siniestro> ListarSiniestros ()
    {
        List<Siniestro> Lista = new List<Siniestro>();
        using (var context = new ConcesionariaFinalContext())
        {
            foreach (Siniestro s in context.Siniestro)
            {
                Lista.Add(s);
            } 
        }
        return Lista;
    }
    public Siniestro? ObtenerSiniestro(int Id)
    {
        using (var context = new ConcesionariaFinalContext())
        {
            var siniestroObtener = context.Siniestro.Where(siniestro=> siniestro.Id == Id).SingleOrDefault();
            return siniestroObtener;
        }
    }
}