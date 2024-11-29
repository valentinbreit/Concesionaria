namespace ConcesionariaFinal.Aplicacion.Entidades;
public class Vehiculo
{
    public int Id {get;set;}
    public string? Dominio {get;set;}
    public string? Marca {get;set;}
    public int AñoFabricacion {get;set;}
    public int TitularId {get;set;}
    public List<Poliza>? Polizas {get; set;}

    public override string ToString()
    {
        return($"El Id del Vehiculo es: {Id}, el dominio es: {Dominio}, la marca es: {Marca}, el año de fabricacion es: {AñoFabricacion}");
    } 
}