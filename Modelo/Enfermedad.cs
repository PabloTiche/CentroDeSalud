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

        public List<string> Sintomas { get;set; }

        public Vacuna Vacuna { get;set; }

        public Enfermedad(string caracteristicas, List<string> sintomas, Vacuna vacuna)
        {
            this.Caracteristicas = caracteristicas;
            this.Sintomas = sintomas;
            this.Vacuna = vacuna;
        }
    }
}
