using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeSalud.Modelo
{
    public class Enfermedad
    {
        public string Caracteristicas { get;set; }

        public List<String> Sintomas { get;set; }

        public Vacuna Vacuna { get;set; }
    }
}
