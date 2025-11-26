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
    }
}