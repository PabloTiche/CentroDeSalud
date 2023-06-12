using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeSalud.Vista
{
    internal class MenuPersona
    {
        Menu menuPrincipal = new();

        public void MenuPrincipalPersona()
        {
            Console.WriteLine($"--------------------------------\n| MENU PERSONA |\n--------------------------------\n");
            Console.WriteLine("\n 0. Volver \n 1. Mostrar \n 2. Buscar \n 3. Cargar \n 4. Modificar");
        }

        public void MenuRegistrarPersona()
        {
            Console.Clear();
            Console.WriteLine($"--------------------------------\n| MENU REGISTRO PERSONA |\n--------------------------------\n");
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
