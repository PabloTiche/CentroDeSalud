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
        public void Welcome()
        {
            Console.WriteLine($"--------------------------------\n| Software Centro De Salud |\n--------------------------------\n");
            Console.WriteLine("Presione una tecla para continuar: "); Console.ReadKey(); Console.Clear();
        }

        public void MenuPrincipal()
        {
            bool salir = false;
        }
    }
}
