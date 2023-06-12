using CentroDeSalud.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeSalud.Vista
{
    internal class MenuPersona
    {
        Menu menuPrincipal = new(); ManejoMenu manejoMenu = new();

        public void MenuPrincipalPersona()
        {
            Console.Clear();
            Console.WriteLine($"------------------------\n|   MENU PERSONA   |\n------------------------\n");
            Console.WriteLine("\n 0. Volver \n 1. Mostrar Personas \n 2. Buscar Persona \n 3. Cargar Persona \n 4. Modificar Persona");

            int opcion = manejoMenu.LeerOpcionValida(new List<int>() { 0, 1, 2, 3, 4 });

            switch ( opcion )
            {
                case 0:
                    {
                        menuPrincipal.MenuPrincipal();
                        break;
                    }
                case 1:
                    {
                        break;
                    }
                case 2:
                    { 
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
            }
        }

        public void MenuRegistrarPersona()
        {
            Console.Clear();
            Console.WriteLine($"---------------------------\n| MENU REGISTRO PERSONA |\n---------------------------\n");
            Console.WriteLine("0. Volver", "1. Registrar Persona");
        }  
        
        public void MenuBuscarPersona()
        {

        } 

        public void MenuEditarPersona()
        {

        }
    }
}
