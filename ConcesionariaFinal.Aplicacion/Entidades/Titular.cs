    namespace ConcesionariaFinal.Aplicacion.Entidades;
    public class Titular: Persona{

    
    public string? Direccion {get;set;}
    public string? Correo {get;set;}
    public List<Vehiculo>? Vehiculos {get;set;}
    
    override
    public  string ToString(){
        return($"El Id del Titular es: {Id}, el dni es: {Dni}, el nombre y apellido es: {Nombre} {Apellido}, el telefono es: {Telefono}, la direccion es: {this.Direccion}, y el correo es {this.Correo}");
    }
}