using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeSalud.Modelo
{
    public class Vacuna
    {
        public List<Enfermedad> Enfermedades { get; set; }

        public string Estrategia { get; set; }

        public string NumeroLote { get; set; }

        public DateOnly FechaVencimiento { get; set; } // public void InTheYear(){Assert.Equal(new DateOnly(2009, 1, 1), InDate.TheYear(2009));}

        public Vacuna(List<Enfermedad> enfermedades, string estrategia, string numeroLote, DateOnly fechaVencimiento) 
        {
            this.Enfermedades = enfermedades;
            this.Estrategia = estrategia;
            this.NumeroLote = numeroLote;
            this.FechaVencimiento = fechaVencimiento;
        }
    
    }
}
