using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeSalud.Modelo
{
    public class Persona
    {
        public int NumeroDNI {  get; set; }

        public string NombreCompleto { get; set; }

        public string Nacionalidad { get; set; }

        public DateTime FechaNacimiento { get; set; } // int year, int month, int day

        public InfoContacto InfoContacto { get; set; }

        public Direccion Direccion { get; set; }

        public Persona(int dni, string nombreCompleto, string nacionalidad, DateTime fechaNacimiento, InfoContacto infoContacto, Direccion direccion)
        {
            this.NumeroDNI = dni;
            this.NombreCompleto = nombreCompleto;
            this.Nacionalidad = nacionalidad; 
            this.FechaNacimiento = fechaNacimiento;
            this.InfoContacto = infoContacto;  
            this.Direccion = direccion;
        }

        public string DatosCompletosPersona()
        {
            return $"Nombre Completo: {this.NombreCompleto}.\n" +
                   $"Fecha De Nacimiento: {this.FechaNacimiento:dd/MM/yyyy}.\n" +
                   $"Nacionalidad: {this.Nacionalidad}.\n" +
                   $"Numero De Documento: {this.NumeroDNI}.\n" +
                   $"{InfoContacto.DatosCompletosInfoContacto()}" +
                   $"{Direccion.DatosCompletosDireccion()}";
        }
    }
}
