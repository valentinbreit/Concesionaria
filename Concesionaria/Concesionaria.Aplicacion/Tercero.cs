  //private int _id {get;}
    
    //private string? _apellido;
    //private string? _nombre;
    //private int _telefono;
    namespace Concesionaria.Aplicacion;
    public class Tercero : Persona{
    private string? _nombreAseguradora;
    private int _idSiniestro;


    public Tercero(int id,int dni,string apellido,string nombre,int telefono, string nombreAseguradora,int idSini):base(id,dni,apellido,nombre,telefono){
        this._idSiniestro=idSini;
        this._nombreAseguradora=nombreAseguradora;

    }

    // override
    //  public void SetId(int id){
    //     this._id= id;       
    // }
    // override
    // public  int GetId(){
    //     return this._id;
    // }

    // override
    // public  void SetDni(int dni){
    //     this._dni=dni;
    // }

    // override
    // public  int GetDni(){
    //     return this._dni;
    // }

    // override
    // public  void SetApellido(string apellido){
    //     this._apellido=apellido;
    // }
 
    // override
    // public  string? GetApellido(){
    //     return this._apellido;
    // }

    // override
    // public  void SetNombre(string nombre){
    //     this._nombre=nombre;
    // }

    // override
    // public  string? GetNombre(){
    //     return this._nombre;
    // }

    // override
    // public  void SetTelefono(int telefono){
    //     this._telefono=telefono;
    // }

    // override
    // public  int GetTelefono(){
    //     return this._telefono;
    // }

    // public void SetNombreAseguradora (string? nombreAseguradora){
    //     this._nombreAseguradora=nombreAseguradora;
    // }

    // public string? GetNombreAseguradora(){
    //     return this._nombreAseguradora;
    // }

    // public int GetIdSiniestro(){ //solo hago un get no? no se puede setear desde aca
    //     return this._idSiniestro;
    // }

    override
    public  string ToString(){
        return($"El Id del Tercero es: {Id}, el dni es: {Dni}, el nombre y apellido es: {Nombre} {Apellido}, el telefono es: {Telefono}, el nombre de su aseguradora es {this._nombreAseguradora}, y el siniestro en el que participo es: {this._idSiniestro}");
    }

}
