using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;

namespace ConcesionariaFinal.Repositorios;

public class RepositorioVehiculo : IRepositorioVehiculo
{
    public void AgregarVehiculo (Vehiculo v)
    {
        using (var context = new ConcesionariaFinalContext())
        {
            context.Vehiculo.Add(v);
            context.SaveChanges();
        }
    }

    public void  EliminarVehiculo (int Id)
    {
        using (var context = new ConcesionariaFinalContext()){
            var VehiculoBorrar = context.Vehiculo.Where(v => v.Id == Id).SingleOrDefault();
            if (VehiculoBorrar !=null){
                context.Vehiculo.Remove(VehiculoBorrar);
            }
            context.SaveChanges();
        }
    }

    public void ModificarVehiculo(Vehiculo v)
    {
        using (var context = new ConcesionariaFinalContext())
        {
            var VehiculoModificar = context.Vehiculo.Where(vehiculo => vehiculo.Id == v.Id).SingleOrDefault();
            if (VehiculoModificar !=null)
            {
                VehiculoModificar.Id= v.Id;
                VehiculoModificar.Dominio=v.Dominio;
                VehiculoModificar.Marca=v.Marca;
                VehiculoModificar.AñoFabricacion=v.AñoFabricacion;
                VehiculoModificar.TitularId=v.TitularId;
                VehiculoModificar.Polizas=v.Polizas;

            }
            context.SaveChanges();
        }
    }

    public List<Vehiculo> ListarVehiculos ()
    {
        List<Vehiculo> Lista = new List<Vehiculo>();
        using (var context = new ConcesionariaFinalContext())
        {
            foreach (Vehiculo t in context.Vehiculo)
            {
                Lista.Add(t);
            } 
        }
        return Lista;
    }

    public Vehiculo? ObtenerVehiculo(int Id)
    {
        using (var context = new ConcesionariaFinalContext())
        {
            var VehiculoBuscar = context.Vehiculo.Where(Vehiculo => Vehiculo.Id == Id).SingleOrDefault();
            return VehiculoBuscar;
        }
    }
}