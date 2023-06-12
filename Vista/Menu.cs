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
        

        public void MenuWelcome()
        {
            Console.WriteLine($"--------------------------------\n|   Software Centro De Salud   |\n--------------------------------\n");
            Console.WriteLine("Presione una tecla para continuar: "); Console.ReadKey(); Console.Clear(); this.MenuPrincipal();
        }

        public void MenuPrincipal()
        {
            ManejoMenu manejoMenu = new();  MenuPersona menuPersona = new();
            MenuVacuna menuVacuna = new(); MenuFormulario menuFormulario = new();
            MenuTurno menuTurno = new(); MenuVacunacion menuVacunacion = new();

            
            
            Console.Clear();
            Console.WriteLine("-- MENU PRINCIPAL --\n\n 0. Salir \n 1. Personas\n 2. Vacunacion \n 3. Formularios \n 4. Turnos \n 5. Vacunas");

            int opcion = manejoMenu.LeerOpcionValida(new List<int>() { 0, 1, 2, 3, 4, 5 });

            switch(opcion)
            {
                case 0:
                    {    
                        break;
                    }
                case 1:
                    {
                        menuPersona.MenuPrincipalPersona();
                        break;
                    }
                case 2:
                    {
                        menuVacuna.MenuPrincipalVacuna();
                        break;
                    }
                case 3:
                    {
                        menuFormulario.MenuPrincipalFormulario();
                        break;
                    }
                case 4:
                    {
                        menuTurno.MenuPrincipalTurno();
                        break;
                    }
                case 5:
                    {
                        menuVacunacion.MenuPrincipalVacunacion();
                        break;
                    }
            }
            
        }


    }
}
