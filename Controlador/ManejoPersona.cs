using CentroDeSalud.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CentroDeSalud.Controlador
{
    public class ManejoPersona
    {

        public List<Persona> ObtenerDatosPersonaDB() 
        {
            List<Persona> personas = null;

            string baseDatos = "DB/DB.json";

            try
            {
                if (File.Exists(baseDatos)) personas = JsonSerializer.Deserialize<List<Persona>>(File.ReadAllText(baseDatos));

                else personas = new List<Persona>();

            }
            catch (JsonException) { Console.WriteLine("\nNo existe nunguna persona en la Base de Datos"); }

            catch (Exception ex) { Console.WriteLine($"Ocurrio un error inesperado.\nDetalle: {ex.Message}"); }

            return personas;
        }


    }
}
