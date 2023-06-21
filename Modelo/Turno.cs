using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeSalud.Modelo
{
    internal class Turno
    {
        public DateTime FechaTurno { get; set; }

        public TimeOnly HoraTurno { get; set; } // year, month, da

        public Persona Paciente { get; set; }

        public string? MutualPaciente { get; set; }

        public Persona PersonalMedico { get; set; }

        public string? DetallesDeConsulta { get; set; }


    }
}
