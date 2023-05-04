namespace Concesionaria.Aplicacion;
public class Vehiculo
{
    public int _id{get;set;}
    public string? _dominio{get;set;}
    public string? _marca{get;set;}

    public int _añoFabricacion{get;set;}
    public int _idTitular{get;set;}

    public void SetId(int id){
        this._id=id;
    }

    public int GetId(){
        return this._id;
    }

    public void SetDominio(string dominio){
        this._dominio=dominio;
    }

    public string? GetDominio(){ //es necesario el signo "?" en donde esa el tipo de retorno (string)
        return this._dominio;
    }

    public void SetMarca(string? marca){
        this._marca=marca;
    }

    public string? GetMarca(){
        return this._marca;
    }

    public void SetAñoFabricacion(int año){
        this._añoFabricacion=año;
    }

    public int GetAñoFabricacion(){
        return this._añoFabricacion;
    }

    public void GetIdTitular(){
       // this._idTitular= //Como hago para setear el id del titular? tengo q hacer q la clase vehiculo conozca a la clase titular?
    }
}
