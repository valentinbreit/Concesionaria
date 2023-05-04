namespace Concesionaria.Aplicacion;
public class Poliza
{
    public int _id{get;set;}
    public int _idVehiculo{get;set;}
    public double _valorAsegurado{get;set;}
    public string? _franquicia{get;set;}
    public string? _cobertura{get;set;}

    public string? _fechaInicio; //de que tipo es la fecha?

    public string? _fechaFin;

    public void SetId(int id){
        this._id=id;
    }

    public int GetId(){
        return this._id;
    }

    public void SetIdVehiculo(int id){
        this._idVehiculo=id;
    }

    public int GetIdVehiculo(){
        return this._idVehiculo;
    }

    public void SetValorAsegurado(double valor){
        this._valorAsegurado=valor;
    }

    public double GetValorAsegurado (){
        return this._valorAsegurado;
    }

    public void SetFranquicia(string? franquicia){
        this._franquicia=franquicia;
    }

    public string? GetFranquicia(){
        return this._franquicia;
    }

    public void SetCobertura(string? cobertura){
        this._cobertura=cobertura;
    }

    public string? GetCobertura(){
        return this._cobertura;
    }





}