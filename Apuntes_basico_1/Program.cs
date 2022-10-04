// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello World ejercicios básicos en Sharp!");
Console.WriteLine("Esta sección abarca sentencias básicas de escritura y lectura en C#.");

Console.Title = "Notas de C# básico.";

#region Comentarios
///Creando un tipo de región plegable.
#endregion

#region Ingreso de datos
string nombre;
Console.WriteLine("\nIngresa tu nombre."); ///Impresión en pantalla.
nombre = Console.ReadLine(); ///Lectura de datos por teclado.
Console.WriteLine("Tu nombre es: " + nombre);
#endregion

///Tipos de variables comunes.
#region Tipos de variable comunes.
int entero = 500;
float flotante = 500.50f;
double doble = 250.50;
decimal midecimal = 500.20m;
byte mibyte = 7; ///Rangos de 0 a 255.
bool boleano = false;
string cadena = "Esta cadena.";
#endregion

///Nulables.
#region Nulables. Secc 4.1
bool? nulable = null; ///Agregando un ? puede aceptar valor nulo pudiendo cambiar posteriormente.
int? numero_2 = null; ///Puede ser nulo pero posteriormente recibe un valor.
#endregion

///Tipos anonimos:
Console.WriteLine("\nTipos anónimos:");
#region Tipos anónimos.
var clientes = new[]
{
    new { Nombre = "Jaime", Apellido = "Garza"},
    new { Nombre = "Andrea", Apellido = "Jimenez"},
    new { Nombre = "Pedro", Apellido = "Gomez"}
};
foreach (var cl in clientes)
{
    Console.WriteLine("ClienteS - Nombre {0}, Apellido {1}", cl.Nombre, cl.Apellido); ///Impresión en pantalla.
}
#endregion

///Tuplas:
Console.WriteLine("\nTuplas:");
#region Tuplas
var cliente = (Nombre: "Fernando", Apellido: "Martinez");
Console.WriteLine($"Cliente: {cliente.Nombre}, {cliente.Apellido}"); ; ///Impresión en pantalla.
#endregion

///Operadores matemáticos.
Console.WriteLine("\nOperadores matemáticos: ");
#region Operadores matemáticos.
const int consUno = 10;
const int consDos = 2;

int suma = consUno + consDos;
Console.WriteLine("Suma: " + suma);

int resta = consUno - consDos;
Console.WriteLine("Resta: " + resta);

int multip = consUno * consDos;
Console.WriteLine("Multiplicación: " + multip);
#endregion

///Operadores relacionales básicos.
Console.WriteLine("\nOperadores relacionales básicos: ");
#region Operadores relacionales básicos:
Console.WriteLine("\nIngresa un número entero.");
int num = Int32.Parse(Console.ReadLine()); ///Lee números ingresados por teclado.
if(consUno == num)
{
    Console.WriteLine("El número es igual a la constante.");
}
if(consUno != num)
{
    Console.WriteLine("El número no es igual la constante.");
}
if(num < consUno)
{
    Console.WriteLine("El número es menor a la constante.");
}
#endregion

///Operadores lógicos.
Console.WriteLine("\nOpetradores lógicos: ");
#region operadores lógicos:
String Y = "&&";
String O = "||";

Console.WriteLine("El opetradore lógico para condicional AND es: "+ Y);
Console.WriteLine("El opetradore lógico para condicional OR es: " + O);
#endregion

///Control de errores con try-Catch:
Console.WriteLine("\nControl de errores con try-Catch:");
#region Control de errores:
Console.WriteLine("Ingresa otro número con error para probar Try_Catch.");
try
{
    int numIng = Int32.Parse(Console.ReadLine());
}
catch(System.FormatException ae)
{
    Console.WriteLine("El error es: "+ae);
}
#endregion

///Desechar excepción: Throw:
Console.WriteLine("\nDesechar excepción: Throw:");
#region Desechar excepción: Throw.
Console.WriteLine("Ingresa otro número con error para probar Desechar excepción: Throw.");
try
{
    int numIng = Int32.Parse(Console.ReadLine());
}
catch (System.FormatException ae)
{
    if(ae.Message == null)
    {
        throw;
    }
    else
    {
        Console.WriteLine("El error es: " + ae.Message);
    }
}
#endregion

//Console.ReadKey();