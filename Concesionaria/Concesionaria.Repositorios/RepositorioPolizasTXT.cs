namespace Concesionaria.Repositorios;
using Concesionaria.Aplicacion;
public class RepositorioPolizasTXT : IRepositorioPoliza
{
    readonly string _nombreArch = "poliza.txt";
    
   
    public void AgregarPoliza(Poliza poliza)
    {
        List<Poliza> lista=ListarPolizas();
        int i=0;
        while (i < lista.Count){
            i++;
        }
        lista[i]=poliza;        
        using var sw = new StreamWriter(_nombreArch,true);
        escribir(poliza,sw);
    }

    public void escribir(Poliza poliza, StreamWriter sw)
    {
        sw.WriteLine(poliza._id);
        sw.WriteLine(poliza._idVehiculo);
        sw.WriteLine(poliza._valorAsegurado);
        sw.WriteLine(poliza._franquicia);
        sw.WriteLine(poliza._cobertura);
        sw.WriteLine(poliza._fechaInicio);
        sw.WriteLine(poliza._fechaFin);
    }

    public void ModificarPoliza(Poliza poliza)
    {
        List<Poliza> lista=ListarPolizas();
        int i= 0;
        while((i<lista.Count) && (lista[i]._id != poliza._id))
        {
           i++;
        } 
        if(lista[i]._id==poliza._id)
        {
            Console.WriteLine("Ingrese el ID del vehiculo modificado");
            lista[i]._idVehiculo=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor asegurado modificado");
            lista[i]._valorAsegurado=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la franquicia modificada");
            lista[i]._franquicia=Console.ReadLine();
            Console.WriteLine("Ingrese la cobertura modificada");
            lista[i]._cobertura=Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de inicio modificada");
            lista[i]._fechaInicio=Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de fin modificada");
            lista[i]._fechaFin=Console.ReadLine();
            using var sw= new StreamWriter(_nombreArch,false);
            foreach (Poliza p in lista)
            {
                escribir(p,sw);
            }
        }
    }

    public void EliminarPoliza(int id)
    {
        List<Poliza> lista=ListarPolizas();
        using var sw= new StreamWriter(_nombreArch,false);
        int i= 0;
        while((i<lista.Count) && (lista[i]._id != id))
        {
           i++;
        } 
        if(lista[i]._id==id)
        {
            lista.RemoveAt(i);
            foreach (Poliza p in lista)
            {
                escribir(p,sw);
            }
        }
    }

    public List<Poliza> ListarPolizas()
    {
        var resultado =new List<Poliza>();
        using var sr= new StreamReader(_nombreArch);
        while (!sr.EndOfStream)
        {
            var poliza = new Poliza();
            poliza._id = int.Parse(sr.ReadLine() ?? "");
            
            resultado.Add(poliza);
        }
        return resultado;

    }





}