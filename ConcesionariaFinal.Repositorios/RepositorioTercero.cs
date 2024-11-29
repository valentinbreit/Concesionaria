using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;
namespace ConcesionariaFinal.Repositorios;

public class RepositorioTercero : IRepositorioTercero
{
    public void AgregarTercero (Tercero t)
    {
    {
        using (var context = new ConcesionariaFinalContext())
        {
            context.Tercero.Add(t);
            context.SaveChanges();
        }
    }
    }

    public void EliminarTercero (int Id)
    {
        using (var context = new ConcesionariaFinalContext())
        {
            var terceroEliminar = context.Tercero.Where(tercero=> tercero.Id == Id).SingleOrDefault();
            if (terceroEliminar != null)
            {
                context.Tercero.Remove(terceroEliminar);
            }
            context.SaveChanges();
        }
    }

    public void ModificarTercero (Tercero t)
    {
        using (var context = new ConcesionariaFinalContext())
        {
            var terceroModificar = context.Tercero.Where(tercero=> tercero.Id == t.Id).SingleOrDefault();
            if (terceroModificar !=null)
            {
                terceroModificar.Id=t.Id;
                terceroModificar.Dni=t.Dni;
                terceroModificar.Apellido=t.Apellido;
                terceroModificar.Nombre=t.Nombre;
                terceroModificar.Telefono=t.Telefono;
                terceroModificar.nombreAseguradora=t.nombreAseguradora;
                terceroModificar.SiniestroId=t.SiniestroId;

            }
            context.SaveChanges();
        }
    }

    public List<Tercero> ListarTerceros ()
    {
        List<Tercero> Lista = new List<Tercero>();
        using (var context = new ConcesionariaFinalContext())
        {
            foreach (Tercero t in context.Tercero)
            {
                Lista.Add(t);
            } 
        }
        return Lista;
    }
    
    public Tercero? ObtenerTercero (int Id)
    {
        using (var context = new ConcesionariaFinalContext())
        {
            var terceroObtener = context.Tercero.Where(tercero=> tercero.Id== Id).SingleOrDefault();
            return terceroObtener;
        }
    }
}