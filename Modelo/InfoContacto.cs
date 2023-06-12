using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeSalud.Modelo
{
    public class InfoContacto
    {
        public string TelPersonal { get; set; }

        public string TelEmergencia { get; set;}

        public string Email { get; set; }

        public InfoContacto(string telefonoPers, string telefonoEmerg, string email) 
        { 
            this.TelPersonal = telefonoPers;
            this.TelEmergencia = telefonoEmerg;
            this.Email = email;
        }

        public string DatosCompletosInfoContacto()
        {
            return $"Email: {this.Email}.\n" +
                   $"Telefono Personal: {this.TelPersonal}.\n" +
                   $"Telefono Emergencia: {this.TelEmergencia}.\n";
        }
    }
}
