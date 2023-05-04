namespace Concesionaria.Aplicacion;
public class Siniestro
{
    public int _id{get;set;}
    public int _idPoliza{get;set;}
    public string? _fechaIngreso{get;set;}//tomada por el sistema al momento de carga. 
    public string? _fechaDeOcurrencia{get;set;}
    public string? _direccion{get;set;}
    
    public string? _descripcion{get;set;}

    
}