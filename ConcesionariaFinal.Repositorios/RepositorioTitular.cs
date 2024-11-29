using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace ConcesionariaFinal.Repositorios;

public class RepositorioTitular : IRepositorioTitular

{
    public void AgregarTitular (Titular t)
    {
        using (var context = new ConcesionariaFinalContext())
        {
            var titularAgregar = context.Titular.Where(titular=> titular.Dni == t.Dni).SingleOrDefault();
            if (titularAgregar == null)
            {
                context.Titular.Add(t);
            }
            context.SaveChanges();
        }

    }

    public void  EliminarTitular (int Id)
    {
        using (var context = new ConcesionariaFinalContext()){
            /*var vehiculosBorrar = context.Vehiculo.Where(v => v.TitularId == Id).SingleOrDefault();
            while (vehiculosBorrar != null)
            {
                var repo = new RepositorioVehiculo();
                repo.EliminarVehiculo(vehiculosBorrar.Id);
            }*/
            var titularBorrar = context.Titular.Where(t=> t.Id == Id).SingleOrDefault();
            if (titularBorrar !=null){
                context.Titular.Remove(titularBorrar);
            }
            context.SaveChanges();
        }

    }

    public void ModificarTitular(Titular t)
    {
        using (var context = new ConcesionariaFinalContext())
        {
            var titularModificar = context.Titular.Where(titular=> titular.Id == t.Id).SingleOrDefault();
            if (titularModificar !=null)
            {
                titularModificar.Id=t.Id;
                titularModificar.Dni=t.Dni;
                titularModificar.Apellido=t.Apellido;
                titularModificar.Nombre= t.Nombre;
                titularModificar.Telefono= t.Telefono;
                titularModificar.Direccion=t.Direccion;
                titularModificar.Correo=t.Correo;
                titularModificar.Vehiculos=t.Vehiculos;  
            }
            context.SaveChanges();

        }

    }
    public List<Titular> ListarTitulares ()
    {
        List<Titular> Lista = new List<Titular>();
        using (var context = new ConcesionariaFinalContext())
        {
            foreach (Titular t in context.Titular)
            {
                Lista.Add(t);
            } 
        }
        return Lista;
    }
    public Titular? ObtenerTitular(int Id)
    {
        using (var context = new ConcesionariaFinalContext())
        {
            var titularBuscar = context.Titular.Where(titular=> titular.Id== Id).SingleOrDefault();
            return titularBuscar;
        }
        //context.SaveChanges();
    }

    public List<Titular> ListarTitularesConSusVehiculos(){
        List<Titular> titulares = new List<Titular>();
        using (var context = new ConcesionariaFinalContext())
        {
            titulares = context.Titular.Include(t => t.Vehiculos).ToList();
        }
        return titulares;
    }
}