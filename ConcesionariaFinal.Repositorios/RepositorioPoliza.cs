using ConcesionariaFinal.Aplicacion.Entidades;
using ConcesionariaFinal.Aplicacion.Interfaces;

namespace ConcesionariaFinal.Repositorios;

public class RepositorioPoliza : IRepositorioPoliza {
    public void AgregarPoliza (Poliza poliza) {
        using (var context = new ConcesionariaFinalContext())
        {
            context.Poliza.Add(poliza);
            context.SaveChanges();
        
        }
    }
      

    public void EliminarPoliza (int id) {
        using (var context = new ConcesionariaFinalContext()) {
            var poliza = context.Poliza.Where(p => p.Id == id).SingleOrDefault();
            if (poliza != null) {
                context.Poliza.Remove(poliza);
                context.SaveChanges();
            }
        }
    }

    public void ModificarPoliza (Poliza p) {
        using (var context = new ConcesionariaFinalContext())
        {
            var PolizaModificar = context.Poliza.Where(poliza=> poliza.Id == p.Id).SingleOrDefault();
            if (PolizaModificar !=null)
            {
                PolizaModificar.Id=p.Id;
                PolizaModificar.ValorAsegurado= p.ValorAsegurado;
                PolizaModificar.Franquicia= p.Franquicia;
                PolizaModificar.Cobertura= p.Cobertura;
                PolizaModificar.FechaInicio= p.FechaInicio;
                PolizaModificar.FechaFin=p.FechaFin;
                PolizaModificar.VehiculoId=p.VehiculoId;
                PolizaModificar.Siniestros=p.Siniestros;  
            }
            context.SaveChanges();
        }
    }

    public List<Poliza> ListarPolizas () {
        List<Poliza> Lista = new List<Poliza>();
        using (var context = new ConcesionariaFinalContext())
        {
            foreach (Poliza p in context.Poliza)
            {
                Lista.Add(p);
            } 
        }
        return Lista;
    }

    public Poliza? ObtenerPoliza (int id) {
        using (var context = new ConcesionariaFinalContext())
        {
            var polizaBuscar = context.Poliza.Where(poliza=> poliza.Id== id).SingleOrDefault();
            return polizaBuscar;
        }
        //context.SaveChanges();
    }
    
}