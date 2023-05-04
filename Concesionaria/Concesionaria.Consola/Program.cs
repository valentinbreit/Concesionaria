using Concesionaria.Repositorios;
using Concesionaria.Aplicacion;


// creo todas las instancias del repositorio
RepositorioTitularTXT repositorioTitular = new RepositorioTitularTXT();
RepositorioPolizasTXT repositorioPolizas = new RepositorioPolizasTXT();

// creo todas las instancias de los use case del titular
AgregarTitularUseCase agregoTitular = new AgregarTitularUseCase(repositorioTitular);
EliminarTitularUseCase eliminoTitular = new EliminarTitularUseCase(repositorioTitular);
ModificarTitularUseCase modificoTitular = new ModificarTitularUseCase(repositorioTitular);
ListarTitularesUseCase listoTitulares = new ListarTitularesUseCase(repositorioTitular);

// creo todas las instancias de los use case de las polizas
AgregarPolizaUseCase agregoPoliza = new AgregarPolizaUseCase(repositorioPolizas);
EliminarPolizaUseCase eliminoPoliza = new EliminarPolizaUseCase(repositorioPolizas);
ModificarPolizaUseCase modificoPoliza = new ModificarPolizaUseCase(repositorioPolizas);
ListarPolizaUseCase listoPolizas = new ListarPolizaUseCase(repositorioPolizas);


// # HAY QUE CREAR OTRO REPOSITORIO PARA LOS AUTOS?
// creo todas las instancias de los use case de los vehiculos
// AgregarVehiculoUseCase agregarVehiculo = new AgregarVehiculoUseCase();
// EliminarVehiculoUseCase eliminoVehiculo = new EliminarVehiculoUseCase();
// ModificarVehiculoUseCase modificoVehiculo = new ModificarVehiculoUseCase();
// ListarVehiculosUseCase listoVehiculos = new ListarVehiculosUseCase();


// Creamos un menù de opciones para que se realice lo que desee el usuario
eligeOpcionesGenerales();





// contiene el menu donde llevamos al usuario segun su preferencia a la accion a realizar dentro del programa
void eligeOpcionesGenerales(){
    // Escribo las opciones que puede tomar el usuario
    System.Console.WriteLine("Escriba 1 si desea realizar operaciones con titulares.");
    System.Console.WriteLine("Escriba 2 si desea realizar operaciones con vehiculos.");
    System.Console.WriteLine("Escriba 3 si desea realizar operacones con poliza.");
    System.Console.WriteLine("No escriba nada y oprima 'Enter' si desea terminar el programa.");
    char? opcionElegida = char.Parse(System.Console.ReadLine());


    // realizo un switch para derivar a la opcion elegida por el usuario siempre y cuando sea una valida
    switch (opcionElegida){
        // lo llevo a que pueda realizar cualquier accion permitida con los titulares
        case '1': eligeOpcionesConTitulares();
                  break;
        // lo llevo a que pueda realizar cualquier accion permitida con los vehiculos
        case '2': eligeOpcionesConVehiculos();
                  break;
        // lo llevo a que pueda realizar cualquier accion permitida con las polizas
        case '3': eligeOpcionesConPolizas();
                  break;
        // en caso de que no hayan tipeado una opcion correcta les pregunto si desean terminar el programa o
        // solo fue un error
        default: System.Console.WriteLine("Opcion elegida no válida. ¿Usted desea terminar el programa?. (Y/N)");
                 opcionElegida = char.Parse(System.Console.ReadLine());
                 // si me dice que no desea terminar el programa lo vuelvo a llevar al menu
                 if ((opcionElegida == 'N') || (opcionElegida == 'n')){
                    eligeOpcionesGenerales();
                 }
                 // caso de que escriba Y o cualquier otro valor no me interesa y cierro el programa
                 break;
    }
}

// menu de opciones para elegir que accion realizar con las polizas
void eligeOpcionesConPolizas(){
    // Escribo las opciones que puede tomar el usuario
    System.Console.WriteLine("Escriba 1 si desea crear y persistir una poliza.");
    System.Console.WriteLine("Escriba 2 si desea modificar una poliza.");
    System.Console.WriteLine("Escriba 3 si desea eliminar una poliza.");
    System.Console.WriteLine("Escriba 4 si desea listar todas las polizas persistidas.");
    char? opcionElegida = char.Parse(System.Console.ReadLine());
    switch(opcionElegida){
        case '1': creoPolizas();
                  break;
        case '2': modificoPolizas();
                  break;
        case '3': eliminoPolizas();
                  break;
        case '4': listoPolizasPersistidas();
                  break;
        default: System.Console.WriteLine("Opcion no válida. ¿Usted desea volvera a ver las opciones de Vehiculos? (Y/N)");
                 opcionElegida = char.Parse(System.Console.ReadLine());
                 // si me dice que  desea volver a ver su listado de opciones llamo el procedimiento denuevo
                 if ((opcionElegida == 'Y') || (opcionElegida == 'y')){
                    eligeOpcionesConVehiculos();
                 }
                 // caso de que escriba Y o cualquier otro valor no me interesa y cierro el programa
                 break;
    }
}


// listo todas las polizas persistidas
void listoPolizasPersistidas(){
    System.Console.WriteLine("Lista de todos los titulares de vehiculos: ");
    List<Poliza> listaPolizas = listoPolizas.Ejecutar();
    // recorro toda la lista imprimiendo
    foreach(Poliza P in listaPolizas){
        System.Console.WriteLine(P);
    }
    // devuelvo al menu principal
    eligeOpcionesGenerales();
}



// elimino polizas
void eliminoPolizas(){
    bool sigoEliminando = false;
    do{
        System.Console.WriteLine("A continuacion se le pedira que ingrese el id de la poliza para poder ");
        System.Console.WriteLine("buscarla en la base de datos y realizar su eliminacion.");
        // ## EL USUARIO SABE EL NUMERO DE LA POLIZA?
        int idPolizaAEliminar = int.Parse(System.Console.ReadLine());

        eliminoPoliza.Ejecutar(idPolizaAEliminar);

        // consulto si desea seguir eliminando polizas
        System.Console.Write("¿Desea modificar otra poliza? (Y/N): ");
        char? deseaEliminar = char.Parse(System.Console.ReadLine());
        if ((deseaEliminar == 'Y') || (deseaEliminar == 'y')){
            sigoEliminando = true;
        }
        else{
            sigoEliminando = false;
        }
    }while(sigoEliminando);
    // devuelvo al menu principal
    eligeOpcionesGenerales();
}


// modifico las polizas
void modificoPolizas(){
    bool sigoModificando = false;
    do{
        System.Console.WriteLine("A continuacion se le pedira que ingrese el id de la poliza para poder ");
        System.Console.WriteLine("buscarla en la base de datos y realizar su modificacion.");
        // ## EL USUARIO SABE EL NUMERO DE LA POLIZA?
        int idPolizaAModificar = int.Parse(System.Console.ReadLine());
        // ## DEBO MODIFICAR EL PARAMETRO DEL REPOSITORIO PARA PODER BUSCAR LA POLIZA SOLO CON EL ID?
        // modificoPoliza.Ejecutar(idPolizaAModificar);


        // consulto si desea seguir modificando polizas
        System.Console.Write("¿Desea modificar otra poliza? (Y/N): ");
        char? deseaModificar = char.Parse(System.Console.ReadLine());
        if ((deseaModificar == 'Y') || (deseaModificar == 'y')){
            sigoModificando = true;
        }
        else{
            sigoModificando = false;
        }

    }while(sigoModificando);
    // devuelvo al menu principal
    eligeOpcionesGenerales();
}



//creo una poliza y si el usuario quiere la persisto
void creoPolizas(){
    bool sigoCreando = false;
    do{
        Poliza P = pidoDatosPoliza();

        // consulto si se desea persistir al Titular
        System.Console.Write("¿Usted desea persistir la poliza recien creada? (Y/N): ");
        char? deseaPersistir = char.Parse(System.Console.ReadLine());
        if ((deseaPersistir == 'Y') || (deseaPersistir == 'y')){
            // ## necesita un trycatch? persistoPoliza(p);
            agregoPoliza.Ejecutar(P);
        }

        // consulto si desea seguir agregando titulares
        System.Console.Write("¿Desea agregar otra poliza? (Y/N): ");
        char? deseaAgregar = char.Parse(System.Console.ReadLine());
        if ((deseaAgregar == 'Y') || (deseaAgregar == 'y')){
            sigoCreando = true;
        }
        else{
            sigoCreando = false;
        }
    }while(sigoCreando);
    // devuelvo al menu principal
    eligeOpcionesGenerales();
}

// pido todos los datos necesarios para crear una poliza
// int _id int _idVehiculo double _valorAsegurado string? _franquicia string? _cobertura
// # DEBO CREAR OTRO CONSTRUCTOR PARA CREAR UNA POLIZA SOLO CON LOS DATOS PEDIDOS POR EL USUARIO?
Poliza pidoDatosPoliza(){

    System.Console.Write("Ingrese el valor por el cual se asegura: ");
    double valorAseguradoPoliza = double.Parse(System.Console.ReadLine());
    System.Console.Write("Ingrese la franquicia de la poliza: ");
    string? franquiciaPoliza = System.Console.ReadLine();
    System.Console.Write("Ingrese la cobertura de la poliza: ");
    string? coberturaPoliza = System.Console.ReadLine();

    return new Poliza();
}


// menu donde puedo elegir que actividad realizará el usuario
void eligeOpcionesConVehiculos(){
    // Escribo las opciones que puede tomar el usuario
    System.Console.WriteLine("Escriba 1 si desea crear y persistir un vehiculo.");
    System.Console.WriteLine("Escriba 2 si desea modificar un vehiculo.");
    System.Console.WriteLine("Escriba 3 si desea eliminar un vehiculo.");
    System.Console.WriteLine("Escriba 4 si desea listar todos los vehiculos persistidos.");
    char? opcionElegida = char.Parse(System.Console.ReadLine());
    switch(opcionElegida){
        case '1': creoVehiculos();
                  break;
        case '2': modificoVehiculos();
                  break;
        case '3': eliminoVehiculos();
                  break;
        case '4': listoVehiculosPersistidos();
                  break;
        default: System.Console.WriteLine("Opcion no válida. ¿Usted desea volvera a ver las opciones de Vehiculos? (Y/N)");
                 opcionElegida = char.Parse(System.Console.ReadLine());
                 // si me dice que  desea volver a ver su listado de opciones llamo el procedimiento denuevo
                 if ((opcionElegida == 'Y') || (opcionElegida == 'y')){
                    eligeOpcionesConVehiculos();
                 }
                 // caso de que escriba Y o cualquier otro valor no me interesa y cierro el programa
                 break;
    }
}

// modificacion de vehiculos
void modificoVehiculos(){
    bool sigoModificando = false;
    do{

    }while(sigoModificando);
    // devuelvo al menu principal
    eligeOpcionesGenerales();
}


// eliminacion de vehiculos
void eliminoVehiculos(){
    bool sigoEliminando = false;
    do{

    }while(sigoEliminando);
    // devuelvo al menu principal
    eligeOpcionesGenerales();
}

// listo los vehiculos
void listoVehiculosPersistidos(){
    // System.Console.WriteLine("Lista de todos los vehiculos: ");
    // List<Vehiculo> listaVehiculos; // = listoVehiculos.Ejecutar();
    // // recorro toda la lista imprimiendo
    // foreach(Vehiculo V in listaVehiculos){
    //     System.Console.WriteLine(V);
    // }
    // // devuelvo al menu principal
    eligeOpcionesGenerales();
}
// creo un vehiculo
void creoVehiculos(){
    bool sigoCreando = false;
    do{
        Vehiculo V = pidoDatosVehiculo();


        // FALTARIA PERSISTIRLO



        System.Console.Write("¿Desea agregar otro titular? (Y/N): ");
        char? deseaAgregar = char.Parse(System.Console.ReadLine());
        if ((deseaAgregar == 'Y') || (deseaAgregar == 'y')){
            sigoCreando = true;
        }
        else{
            sigoCreando = false;
        }
    // sigo creando vehiculos hasta que el usuario no quiera que crear mas
    } while (sigoCreando);
    // devuelvo al menu principal
    eligeOpcionesGenerales();
}


// modulo para poder pedir todos los datos de los vehiculos
// _id _dominio _marca _añoFabricacion _idTitular
Vehiculo pidoDatosVehiculo(){
    System.Console.Write("Ingrese el dominio del vehiculo: ");
    string? dominioVehiculo = System.Console.ReadLine();

    System.Console.Write("Ingrese la marca del vehiculo: ");
    string? marcaVehiculo = System.Console.ReadLine();

    System.Console.Write("Ingrese el año de fabricacion del vehiculo: ");
    int anioFabricacionVehiculo = int.Parse(System.Console.ReadLine());

    // ## ver que hacer con este constructor ¿como saca el id el mismo auto? ¿como reconoce el id del titular?
    return new Vehiculo();// dominioVehiculo,marcaVehiculo,anioFabricacionVehiculo);
}


// menu donde puede elegir que actividad realizar de los del usuario
void eligeOpcionesConTitulares(){
    // Escribo las opciones que puede tomar el usuario
    System.Console.WriteLine("Escriba 1 si desea crear y persistir un titular.");
    System.Console.WriteLine("Escriba 2 si desea modificar un titular.");
    System.Console.WriteLine("Escriba 3 si desea eliminar un titular.");
    System.Console.WriteLine("Escriba 4 si desea listar todos los titulares persistidos.");
    char? opcionElegida = char.Parse(System.Console.ReadLine());
    switch(opcionElegida){
        // lo llevo a que pueda crear el titular y si lo desea persistirlo
        case '1': creoTitulares();
                  break;
        case '2': modificoTitulares();
                  break;
        case '3': eliminoTitulares();
                  break;
        case '4': listoTitularesPersistidos();
                  break;
        default: System.Console.WriteLine("Opcion no válida. ¿Usted desea volvera a ver las opciones de titulares? (Y/N)");
                 opcionElegida = char.Parse(System.Console.ReadLine());
                 // si me dice que  desea volver a ver su listado de opciones llamo el procedimiento denuevo
                 if ((opcionElegida == 'Y') || (opcionElegida == 'y')){
                    eligeOpcionesConTitulares();
                 }
                 // caso de que escriba Y o cualquier otro valor no me interesa y cierro el programa
                 break;
    }
}



// listo todos los titulares persistidos
void listoTitularesPersistidos(){
    System.Console.WriteLine("Lista de todos los titulares de vehiculos: ");
    List<Titular> listaTitulares = listoTitulares.Ejecutar();
    // recorro toda la lista imprimiendo
    foreach(Titular T in listaTitulares){
        System.Console.WriteLine(T);
    }
    // devuelvo al menu principal
    eligeOpcionesGenerales();
}



// procedimiento para eliminar titulares persistidos
void eliminoTitulares(){
    bool sigoEliminando = false;
    do{
        // pido el dni para buscar al titular
        System.Console.Write("Ingrese un dni válido para modificar un titular: ");
        int DNITitularAEliminar = int.Parse(System.Console.ReadLine());
        eliminoTitular.Ejecutar(DNITitularAEliminar);

        // consulto si desea seguir eliminando titulares
        System.Console.Write("¿Desea modificar otro titular? (Y/N): ");
        char? deseaEliminar = char.Parse(System.Console.ReadLine());
        if ((deseaEliminar == 'Y') || (deseaEliminar == 'y')){
            sigoEliminando = true;
        }
        else{
            sigoEliminando = false;
        }
    }while (sigoEliminando);
    // devuelvo al menu principal
    eligeOpcionesGenerales();
}



// procedimiento para modificar titulares persistidos
void modificoTitulares(){// ## VER SI PUEDO CAMBIAR LOS PARAMETROS DEL METODO MODIFICAR TITULAR
    bool sigoModificando = false;
    do{
        // pido el dni para buscar al titular
        System.Console.Write("Ingrese un dni válido para modificar un titular: ");
        int DNITitularAModificar = int.Parse(System.Console.ReadLine());
        // cargo a un objeto titular que solo tenga el dni
        Titular tAModificar = new Titular(DNITitularAModificar);
        //llamo al metodo
        modificoTitular.Ejecutar(tAModificar);

        // consulto si desea seguir modificando titulares
        System.Console.Write("¿Desea modificar otro titular? (Y/N): ");
        char? deseaModificar = char.Parse(System.Console.ReadLine());
        if ((deseaModificar == 'Y') || (deseaModificar == 'y')){
            sigoModificando = true;
        }
        else{
            sigoModificando = false;
        }
    } while(sigoModificando);
    // devuelvo al menu principal
    eligeOpcionesGenerales();
}


// procedimiento para crear y persistir si se desea los titulares
void creoTitulares(){
    bool sigoCreando = false;
    do{
        Titular T = pidoDatosTitular();

        // consulto si se desea persistir al Titular
        System.Console.Write("¿Usted desea persistir el titular recien creado? (Y/N): ");
        char? deseaPersistir = char.Parse(System.Console.ReadLine());
        if ((deseaPersistir == 'Y') || (deseaPersistir == 'y')){
            persistoTitular(T);
        }

        // consulto si desea seguir agregando titulares
        System.Console.Write("¿Desea agregar otro titular? (Y/N): ");
        char? deseaAgregar = char.Parse(System.Console.ReadLine());
        if ((deseaAgregar == 'Y') || (deseaAgregar == 'y')){
            sigoCreando = true;
        }
        else{
            sigoCreando = false;
        }
    // sigo creando titulares hasta que el usuario no quiera que cree mas titulares
    } while (sigoCreando);
    // devuelvo al menu principal
    eligeOpcionesGenerales();
}


// persisto titular
void persistoTitular(Titular t){
    // me fijo que no haya una excepcion
    try{
        agregoTitular.Ejecutar(t);
    }
    catch (Exception e){// en caso de que ya esté agregado hay una excepcion
        System.Console.WriteLine(e.Message);
    }
}

// string nombre,int telefono, string direccion,string correo
Titular pidoDatosTitular(){
    // pido todos los datos del titular
    System.Console.Write("Ingrese el DNI del nuevo titular: ");
    int DNITitular = int.Parse(System.Console.ReadLine());
    
    System.Console.Write("Ingrese el apellido del titular: ");
    string? ApellidoTitular = System.Console.ReadLine();

    System.Console.WriteLine("Ingrese el nombre del titular: ");
    string? nombreTitular = System.Console.ReadLine();

    System.Console.Write("Ingrese el telefono del titular: ");
    int telefonoTitular = int.Parse(System.Console.ReadLine());

    System.Console.Write("Ingrese la direccion donde reside el titular: ");
    string? direccionTitular = System.Console.ReadLine();

    System.Console.Write("Ingrese el correo del titular: ");
    string? correoTitular = System.Console.ReadLine();

// ## FIJARME EL ID
    return new Titular(-1,DNITitular,ApellidoTitular,nombreTitular,telefonoTitular,direccionTitular,correoTitular);
}