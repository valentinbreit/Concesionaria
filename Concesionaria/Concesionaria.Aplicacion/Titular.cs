namespace Concesionaria.Aplicacion;
public class Titular: Persona
{
    public string? _direccion{get;set;}
    public string? _correo{get;set;}

    public Titular ():base(){
        
    }

    public Titular (int dni):base(dni){
        
    }

    public Titular(int id,int dni,string apellido,string nombre,int telefono, string direccion,string correo):base(id,dni,apellido,nombre,telefono){
        this._direccion=direccion;
        this._correo=correo;

    }

    
    override
    public  string ToString(){
        return($"El Id del Titular es: {Id}, el dni es: {Dni}, el nombre y apellido es: {Nombre} {Apellido}, el telefono es: {Telefono}, la direccion es: {this._direccion}, y el correo es {this._correo}");
    }



}