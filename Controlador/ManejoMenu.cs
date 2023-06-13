using CentroDeSalud.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static CentroDeSalud.Controlador.Exceptions;

namespace CentroDeSalud.Controlador
{
    public class ManejoMenu
    {
        public int LeerOpcionValida(List<int> opcionesValidas)
        {
            int selecc = -1;
            try
            {
                while (!opcionesValidas.Contains(selecc))
                {
                    selecc = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }


            return selecc;
        }

        public void MostrarProvincias()
        {
            Provincias[] Provincias = Enum.GetValues<Provincias>();

            foreach (Provincias Provincia in Provincias)
            {
                Console.WriteLine($"{(int)Provincia}. {Provincia}");
            }
        }

        public string IngresoString(string mensaje)
        {
            bool salir = false;
            string stringCompletoIngresado = "";
            do
            {
                try
                {
                    Console.WriteLine($"\n{mensaje}");
                    stringCompletoIngresado = Console.ReadLine();

                    if (String.IsNullOrEmpty(stringCompletoIngresado))
                    {
                        throw new DatoVacioException();
                    }
                    else if (Regex.IsMatch(stringCompletoIngresado, @"^[0-9]+$"))
                    {
                        throw new SoloLetrasException();
                    }
                    else
                    {
                        salir = true;
                    }
                }
                catch (DatoVacioException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (SoloLetrasException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error inesperado");
                    Console.WriteLine($"Detalle: {ex.Message}");
                }
            }
            while (!salir);

            return stringCompletoIngresado;
        }
    }
}
