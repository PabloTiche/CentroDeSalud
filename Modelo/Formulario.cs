using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeSalud.Modelo
{
    public class Formulario
    {
        public DateTime Fecha { get;set;}

        public Persona Paciente { get;set;}

        public Persona PersonalMedico { get;set;}

        public Formulario(DateTime fecha, Persona paciente, Persona personalMedico)
        {
            this.Fecha = fecha;
            this.Paciente = paciente;
            this.PersonalMedico = personalMedico;
        }
    }
}
