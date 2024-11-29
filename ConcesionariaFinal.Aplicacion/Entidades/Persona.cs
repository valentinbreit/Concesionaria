namespace ConcesionariaFinal.Aplicacion.Entidades;
public abstract class Persona {
    public int Id{get; set;} //que diferencia hay entre propiedades abstractas y normales, publicas o privadas, staticas
    public int Dni{get;set;} = 0;//protected significa q sus hijos lo pueden llamar.
    public string? Apellido{get;set;} = "";
    public string? Nombre{get;set;} = "";
    public int Telefono{get;set;} = 0;
}