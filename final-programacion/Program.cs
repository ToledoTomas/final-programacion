using System;
using System.IO;
using System.Collections.Generic;

namespace GestorArchivos
{
    public class Alumnos
    {
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumDocumento { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public Alumnos()
        {
            Legajo = "";
            Nombre = "";
            Apellido = "";
            NumDocumento = "";
            Email = "";
            Telefono = "";
        }

        public Alumnos(string legajo, string nombre, string apellido, string numDocumento, string email, string telefono)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            NumDocumento = numDocumento;
            Email = email;
            Telefono = telefono;
        }

        public override string ToString()
        {
            return $"{Legajo}, Alumno: {Apellido}, {Nombre}. Numero de Documento: {NumDocumento}, Email: {Email}, Telefono: {Telefono}";
        }

        public string ToTxt()
        {
            return $"{Legajo}|{Apellido}|{Nombre}|{NumDocumento}|{Email}|{Telefono}";
        }

        public string ToCsv()
        {
            return $"{Legajo},{Apellido},{Nombre},{NumDocumento},{Email},{Telefono}";
        }

        public string ToJson()
        {
            return $"[{{\"Legajo\":\"{Legajo}\",\"Apellido\":\"{Apellido}\",\"Nombre\":\"{Nombre}\",\"NumeroDocumento\":\"{NumDocumento}\",\"Email\":\"{Email}\",\"Telefono\":\"{Telefono}\"}}]";
        }

        public string toXml()
        {
            return $"<Alumnos><Alumno><Legajo>{Legajo}</Legajo><Apellido>{Apellido}</Apellido><Nombre>{Nombre}</Nombre><NumDocumento>{NumDocumento}</NumDocumento><Email>{Email}</Email><Telefono>{Telefono}</Telefono></Alumno></Alumnos>";
        }
    }

    public class GestorArchivos
    {
               private const string directorio = "Archivos";
        public GestorArchivos()
        {
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }
        }
        public void AgregarArchivo()
        {
        }

        public void LeerArchivo()
        {
        }

        public void ModificarArchivo()
        {
        }

        public void EliminarArchivo()
        {
        }

        public void ModificarExtensionArchivo()
        {
        }

        public void CrearReporte()
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GestorArchivos gestor = new GestorArchivos();
            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════╗");
                Console.WriteLine("║   SISTEMA DE GESTION DE ARCHIVOS       ║");
                Console.WriteLine("╚════════════════════════════════════════╝");
                Console.WriteLine();
                Console.WriteLine("1. Agregar archivo");
                Console.WriteLine("2. Leer archivo");
                Console.WriteLine("3. Modificar archivo");
                Console.WriteLine("4. Eliminar archivo");
                Console.WriteLine("5. Modificar extension de un archivo");
                Console.WriteLine("6. Crear reporte");
                Console.WriteLine("7. Salir");
                Console.Write("\nSeleccione una opcion: ");

                try
                {
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            gestor.AgregarArchivo();
                            break;
                        case 2:
                            gestor.LeerArchivo();
                            break;
                        case 3:
                            gestor.ModificarArchivo();
                            break;
                        case 4:
                            gestor.EliminarArchivo();
                            break;
                        case 5:
                            gestor.ModificarExtensionArchivo();
                            break;
                        case 6:
                            gestor.CrearReporte();
                            break;
                        case 7:
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        default:
                            Console.WriteLine("Opcion invalida. Intente nuevamente.");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingrese un numero valido.");
                    Console.ReadKey();
                }
            } while (opcion != 7);
        }
    }
}