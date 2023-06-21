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

        public Turno(DateTime fechaTurno, TimeOnly horaTurno, Persona paciente, string mutualPaciente, Persona personalMedico, string detalleConsulta)
        {
            this.FechaTurno = fechaTurno;
            this.HoraTurno = horaTurno;
            this.Paciente = paciente;
            this.MutualPaciente= mutualPaciente;
            this.PersonalMedico = personalMedico;
            this.DetallesDeConsulta = detalleConsulta;
        }


    }
}
