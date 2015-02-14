using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
   
            public class TestComercial
{
static void Main(string[] args)
{
// inicialización del comercial en el sistema
Comercial elComercial = Comercial.Instance();
elComercial.nombre = "Comercial Auto";
elComercial.direccion = "Madrid";
elComercial.email = "comercial@comerciales.com";
// muestra el comercial del sistema
visualiza();
Console.ReadKey();
}
public static void visualiza()
{
Comercial elComercial = Comercial.Instance();
elComercial.visualiza();
}
}
        public class Comercial
        {

        public string nombre { get; set; }
public string direccion { get; set; }
public string email { get; set; }
private static Comercial _instance = null;
private Comercial(){}
public static Comercial Instance()
{
if (_instance == null)
_instance = new Comercial();
return _instance;
}
public void visualiza()
{
Console.WriteLine("Nombre: " + nombre);
Console.WriteLine("Dirección: " + direccion);
Console.WriteLine("Email: " + email);
}
}
        }
    

