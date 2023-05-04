namespace Concesionaria.Aplicacion;
public abstract class Persona
{
    public int Id{get;set;} //que diferencia hay entre propiedades abstractas y normales, publicas o privadas, staticas
    public int Dni{get;set;}//protected significa q sus hijos lo pueden llamar. string? Apellido{get;}
    public string? Apellido{get;set;}
    public string? Nombre{get;set;}
    public int Telefono{get;set;}

    public Persona(int id,int dni,string apellido,string nombre, int telefono){
        this.Id=id;
        this.Dni=dni;
        this.Apellido=apellido;
        this.Nombre=nombre;
        this.Telefono=telefono;
    }
    public Persona (){
        Id= -1;
    }

    public Persona(int dni){
        this.Dni = dni;
    }
    // public abstract void SetId(int id); //no hago set
    // public abstract int GetId();
    // public abstract void SetDni(int dni);
    // public abstract int GetDni();
    // public abstract void SetApellido(string apellido);
    // public abstract string? GetApellido();
    // public abstract void SetNombre(string nombre);
    // public abstract string? GetNombre();
    // public abstract void SetTelefono(int telefono);
    // public abstract int GetTelefono();
    public override abstract string ToString(); //virtual significa sobreescribirlo en la clase q lo hereda
}