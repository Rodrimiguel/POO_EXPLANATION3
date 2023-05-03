using Instituto; // tengo que hacer refencia a la directiva using
using Instituto.Academica;
using System.Data; //manejo de bases de datos
using System.Data.SqlClient; // subconjunto.


Profesor profe = new Profesor();
////////////////-------------------------///////////////////////////////
////////////////-------------------------///////////////////////////////

// using Instituto;
//Instituto.Profesor profe = new Instituto.Profesor();

////////////////-------------------------///////////////////////////////
////////////////-------------------------///////////////////////////////

#region Asignación / Imprimir

Alumno alumno1 = new Alumno();

alumno1.Nombre = "Laura";
alumno1.Apellido = "Alonso";


var alumno2 = new Alumno();
alumno2.Nombre = "Marina";
alumno2.Apellido = "Lopez";

////////////////----------------------------------------------
alumno1.Metodo1(1, "palabra 1", true);  // devuelve void // no hace falta que se lo asigne a nadie.


////////////------------------------
//Console.WriteLine( alumno1.Metodo2());

var resultadostring = alumno1.Metodo2(); // este parametro devuelve un string y se lo asigna a resultadosstring. 

//////---------------------
var alumno99 = alumno1.Metodo3("Carlos");

Console.WriteLine(alumno99.Nombre); // en este caso no hay parentesis porque no le pasamos ningun parametro a la propiedad\
// como si le pasamos parametros el metodo2() alumno1.Metodo2
// siempre parentesis al final en los metodos (y ver si tiene parametros)
// en el caso de propiedades lo usamos sin parentesis porque no esperan ninguna parametro.

// public string Metodo x ()
// tipo de accesibilidad / tipo de retorno / nombremetodos / (parametros)

////////////////-------------------------///////////////////////////////
////////////////-------------------------///////////////////////////////
////////////////-------------------------///////////////////////////////
////////////////-------------------------///////////////////////////////
////////////////-------------------------///////////////////////////////
////////////////-------------------------///////////////////////////////
////////////////-------------------------///////////////////////////////

alumno1.Clave = "nueva clave"; //set
Console.WriteLine(alumno1.Clave); //get
alumno1.DNI = 222222; //set
Console.WriteLine(alumno1.DNI); //get

var alumno3 = new Alumno();
Console.WriteLine(alumno3.Apellido);

var alumno4 = new Alumno("Lucas");
Console.WriteLine(alumno4.Nombre);

var alumno5 = new Alumno(44444);
Console.WriteLine(alumno5.DNI);

var alumno6 = new Alumno("Micaela", "Martinez");
// constructor la vamos a utilizar cuando hacemos el new.
// recordar no repetir tipos.
var alumno7 = new Alumno("Luciano", "Rosas", 32831);
Console.WriteLine($"nombre: {alumno7.Nombre} apellido {alumno7.Apellido} dni: {alumno7.DNI}");


var titulocompleto = alumno7.Saludar("Ingeniero");

Console.WriteLine(titulocompleto);

Console.WriteLine(alumno6.Saludar("Doctora"));

Console.WriteLine(alumno6.Metodo2());

// METODO
// CAJA NEGRA (ASIGNACION, CUENTA)
// LE PASAMOS ALGO Y NOS DEVUEL ALGO

// LA IDEA ES NO TENER TANTA LINEA DE CODIGO Y QUE SE PUEDA REUTILIZAR LO QUE ESTOY HACIENDO.
#endregion


// Tengo que pasar los definidos en la estructura.
alumno6.NivelEstudio = Alumno.TipoNivelEstudio.Secundario; // SET
alumno7.NivelEstudio = Alumno.TipoNivelEstudio.Secundario; // SET
alumno1.NivelEstudio = Alumno.TipoNivelEstudio.Primario; // SET
// Tengo que pasar los definidos en la estructura.
// Muy util (podemos poner un if para preguntar algo)

Console.WriteLine(alumno7.NivelEstudio); // GET (IMPRIMIR/MOSTRAR)


class Alumno
{


    // Recordar primero para mantener un orden 1) constructores 2) Campos y propiedades 3) Metodos.


    #region Construcores
    public Alumno()
    {
        Apellido = "Rosso";
    }

    public Alumno(string nombreinicial)
    {
        Nombre = nombreinicial;
    }
    public Alumno(int documentooriginal)
    {
        documento = documentooriginal;
    }

    public Alumno(string nombreinicial, string apellidoinicial)
    {
        Nombre = nombreinicial;
        Apellido = apellidoinicial;
    }
    public Alumno(string nombreinicial, string apellidoinicial, int doc) : this(nombreinicial, apellidoinicial)
    {

        documento = doc;
    }
    public Alumno(string nombre, string apell, string domic, int dni) : this(nombre, apell, dni)
    {
        Domicilio = domic;
    }
    public Alumno(string nombre, string apell, string domic)
    {
        Apellido = apell;
        Nombre = nombre;
        Domicilio = domic;
    }
    #endregion
    #region Campos y propiedades
    #region Datos Personales
    public string Domicilio { get; set; }
    private string claveguardada;
    private int documento;
    public int DNI
    {
        get { return documento; }
        set { documento = value; }
    }

    public string Clave
    {
        get { return claveguardada; }
        set { claveguardada = value; }
    }
    public string Nombre { get; set; }

    public string Apellido { get; set; }

    #endregion

    /*
        private string apellido;
        public string Apellido{
            get{return apellido;}
            set{apellido=value;}
        }
    */
    #endregion
    #region Metodos
    public void Metodo1(int valor1, string palabra1, bool activo)
    {  // tipo de retorno.

        var valor2 = valor1 + 100;
        var palabracompleta = palabra1 + "esto es una oración";
        claveguardada = "esta es una clave";
    }
    // 1) modificador de acceso (publico, privado, ect)
    // 2) Tipo de retorno void no me devuelve nada. (no vamos a poner return) (se devuele aca dentro)
    // 3) Metodo1 (nombre del metodo) --> podemos reutilizarlos. PODEMOS HACER SOBRECARGA DE METODOS CON EL MISMO NOMBRE
    // PERO CON DIFERENTE PARAMETROS QUE ESPERA.

    //DATOS PRIMITIVOS (STRING, INT, ECT)
    // TIPO COMPLEJOS (OBJETOS,LISTAS) EJ, QUE ME DUELVE UN TIPO ALUMNO. - public alumno Metodo1 -

    public Alumno Metodo3(string Nombre)
    {
        var alumnometodo = new Alumno(Nombre);
        alumnometodo.documento = 4444;
        return alumnometodo;

        //JUGAMOS CON ESTE OBJETO ACA DENTRO (LE VAMOS ASIGNAMOS VALORES Y POR ULTIMO LO RETORNAMOS)
        // CREAMOS UN OBJETO DENTRO DEL METODO 3.


        // me puede devolver un objeto del tipo alumno
        // listas: muchos objeto agrupados en una colección.
    }

    public string Metodo2()
    {
        return claveguardada;
        // llevan a cabo el comportamiento del objeto. (acciones)
    }

    public string Saludar(string titulo)
    {
        var resultado = "Hola soy el/la " + titulo + " " + this.Nombre + " " + this.Apellido;
        return resultado;

    }

    #endregion


    public TipoNivelEstudio NivelEstudio { get; set; } // propiedad del tipo nivel de estudio (enumeracion)
    // NivelEstudio (es donde vamos a guardar el valor) // Una propiedad para guardarla
    #region Enumeraciones
    //establecer valores que ya esten tipados (Que ya le podamos asignar algun valor.)
    public enum TipoNivelEstudio
    {

        Primario,// 100, // PODEMOS ASOCIAR VALORES CON UN VALOR.

        Secundario,

        Terciario,

        Universitario

        // quiero que pasen estos valores

    }


    #endregion


    // NAMESPACE CONJUNTO DE CLASES (AGRUPACION LOGICA NO FISICA) AGRUPACION LA VAMOS A DEFINIR NOSOTROS.
    // VAMOS A ESTABLECER/UTILIZAR UNA ESPECIE DE JERARQUIA.
    // APLICACION DE TODO EL MANEJO DEL INSTITUTO. (ALUMNOS, PROFESORES, PARTE ADMINISTRATIVA, DE FINANZAS.)

}
////////////////-------------------------///////////////////////////////
////////////////-------------------------///////////////////////////////
////////////////-------------------------///////////////////////////////
// namespace Instituto { // todas las clases dentro de este conjunto 

//     public class Profesor{

//     }

//     public class Nota{


//     }
//     public class Cuota {

//     }

//     public class Sueldo{

//     }
////////////////-------------------------///////////////////////////////
namespace Instituto
{
    namespace Academica
    {
        public class Profesor
        {

        }

        public class Nota
        {

        }

    }

    namespace Finanzas
    {
        public class Cuota
        {

        }

        public class Sueldo
        {

        }
    }

    ////////////////-------------------------/////////////////////////////// 




}




