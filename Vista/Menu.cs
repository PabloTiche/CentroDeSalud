using CentroDeSalud.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeSalud.Vista
{
    public class Menu
    {
        
        public void Welcome()
        {
            Console.WriteLine($"--------------------------------\n| Software Centro De Salud |\n--------------------------------\n");
            Console.WriteLine("Presione una tecla para continuar: "); Console.ReadKey(); Console.Clear(); this.MenuPrincipal();
        }

        public void MenuPrincipal()
        {
            ManejoMenu manejoMenu = new ManejoMenu();
            MenuPersona menuPersona = new MenuPersona();

            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("-- MENU PRINCIPAL --\n\n 0. Salir \n 1. Personas\n 2. Vacunacion \n 3. Formularios");

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
                            menuPersona.MenuPrincipalPersona();
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
