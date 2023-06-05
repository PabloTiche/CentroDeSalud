using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeSalud.Modelo
{
    public class Direccion
    {
        public Provincias Provincias { get; set; }

        public string Ciudad { get; set; }

        public string NobreCalle { get; set; }

        public int Altura { get; set; }

        public string CodigoPostal { get; set; }

        public Direccion(Provincias provincia, string ciudad, string nombreCalle, int altura, string codigoPostal)
        {
            this.Provincias = provincia;
            this.Ciudad = ciudad;
            this.NobreCalle = nombreCalle;
            this.Altura = altura;
            this.CodigoPostal = codigoPostal;
        }

    }
}
