using CentroDeSalud.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeSalud.Vista
{
    internal class Menu
    {
        public MenuPersona menuPersona = new MenuPersona();
        public MenuVacuna menuVacuna = new MenuVacuna();
        public ManejoMenu manejoMenu = new ManejoMenu();
        public void Welcome()
        {
            Console.WriteLine($"--------------------------------\n| Software Centro De Salud |\n--------------------------------\n");
            Console.WriteLine("Presione una tecla para continuar: "); Console.ReadKey(); Console.Clear();
        }

        public void MenuPrincipal()
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("-- MENU PRINCIPAL --\n", "0. Salir", "1. Personas", "2. Vacunacion", "3. Formularios");

                int opcion = manejoMenu.LeerOpcionValida(new List<int>() { 0, 1, 2, 3 });

                switch ( opcion )
                {
                    case 0:
                        {
                            salir = true;
                            break;
                        }
                    case 1:
                        {
                            salir = true;
                            break;
                        }
                    case 2:
                        {
                            salir = true;
                            break;
                        }
                    case 3:
                        {
                            salir = false;
                            break;
                        }
                    case 4:
                        {
                            salir = false;
                            break;
                        }
                }
            }
        }


    }
}
