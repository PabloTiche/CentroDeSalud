using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeSalud.Modelo
{
    internal class Vacunacion
    {
        public Persona Persona { get; set; }

        public DateTime FechaDeVacunacion { get; set; }

        Vacuna Vacuna { get; set; }

        public Vacunacion(Persona persona, DateTime fechaDeVacunacion, Vacuna vacuna)
        {
            this.Persona = persona;
            this.FechaDeVacunacion = fechaDeVacunacion;
            this.Vacuna = vacuna;
        }

        public string DatosCompletosVacunacion()
        {
            return $"Nombre Completo: {this.Persona.NombreCompleto}.\n" +
                   $"Fecha De Vacunacion: {this.FechaDeVacunacion}.\n" +
                   $"Vacuna: {this.Vacuna}.\n";
        }
    }
}
