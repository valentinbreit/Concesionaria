namespace Concesionaria.Repositorios;
using Concesionaria.Aplicacion;
public class RepositorioTitularTXT : IRepositorioTitular
{
    readonly string _nombreArch = "titular.txt";
    
    public int setearId()
    {
        List<Titular> lista=ListarTitulares();
        return (lista[lista.Count].Id)+1;
    }
    public void AgregarTitular(Titular titular)
    {
        List<Titular> lista=ListarTitulares();
        int i= 0;
        while((i<lista.Count) && (lista[i].Dni != titular.Dni))
        {
           i++;
        } 
        if(lista[i].Dni==titular.Dni)
        {
            throw new Exception($"El titular con DNI {titular.Dni} ya está agregado.");//try catch en la consola para manejar la excepcion
        }
        
        using var sw = new StreamWriter(_nombreArch,true);
        titular.Id=setearId();
        escribir(titular,sw);
    }

    public void escribir(Titular titular, StreamWriter sw)
    {
        sw.WriteLine(titular.Id);
        sw.WriteLine(titular.Nombre);
        sw.WriteLine(titular.Apellido);
        sw.WriteLine(titular.Dni);
        sw.WriteLine(titular.Telefono);
        sw.WriteLine(titular._direccion);
        sw.WriteLine(titular._correo);
    }

    public void ModificarTitular(Titular titular)
    {
        List<Titular> lista=ListarTitulares();
        int i= 0;
        while((i<lista.Count) && (lista[i].Dni != titular.Dni))
        {
           i++;
        } 
        if(lista[i].Dni==titular.Dni)
        {
            Console.WriteLine("Ingrese el nombre a modificar");
            lista[i].Nombre=Console.ReadLine();
            Console.WriteLine("Ingrese el apellido a modificar");
            lista[i].Apellido=Console.ReadLine();
            Console.WriteLine("Ingrese el dni a modificar");
            lista[i].Dni=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el telefono a modificar");
            lista[i].Telefono=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la direccion a modificar");
            lista[i]._direccion=Console.ReadLine();
            Console.WriteLine("Ingrese el correo a modificar");
            lista[i]._correo=Console.ReadLine();
            using var sw= new StreamWriter(_nombreArch,false);
            foreach (Titular t in lista)
            {
                escribir(t,sw);//que pasa con el sw en false cada vez q escribe
            }
        }
    }

    public void EliminarTitular(int dni)
    {
        List<Titular> lista=ListarTitulares();
        using var sw= new StreamWriter(_nombreArch,false);
        int i= 0;
        while((i<lista.Count) && (lista[i].Dni != dni))
        {
           i++;
        } 
        if(lista[i].Dni==dni)
        {
            lista.RemoveAt(i);
            foreach (Titular t in lista)
            {
                escribir(t,sw);//que pasa con el sw en false cada vez q escribe
            }
        }
    }

    public List<Titular> ListarTitulares()
    {
        var resultado =new List<Titular>();
        using var sr= new StreamReader(_nombreArch);
        while (!sr.EndOfStream)
        {
            var titular = new Titular();
            titular.Id = int.Parse(sr.ReadLine() ?? "");
            
            resultado.Add(titular);
        }
        return resultado;

    }





}