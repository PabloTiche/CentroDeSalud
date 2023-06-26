using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeSalud.Modelo
{
    public class Vacunacion
    {
        public Persona Persona { get; set; }

        public DateTime FechaDeVacunacion { get; set; }

        public Vacuna Vacuna { get; set; }

        public string Detalles { get; set; }

        public Vacunacion(Persona persona, DateTime fechaDeVacunacion, Vacuna vacuna, string detalles)
        {
            this.Persona = persona;
            this.FechaDeVacunacion = fechaDeVacunacion;
            this.Vacuna = vacuna;
            this.Detalles = detalles;
        }

        public string DatosCompletosVacunacion()
        {
            return $"Nombre Completo: {this.Persona.NombreCompleto}.\n" +
                   $"Fecha De Vacunacion: {this.FechaDeVacunacion}.\n" +
                   $"Vacuna: {this.Vacuna}.\n" +
                   $"Detalle: {this.Detalles}.\n";
        }
    }
}
