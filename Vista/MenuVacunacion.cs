using CentroDeSalud.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeSalud.Vista
{
    internal class MenuVacunacion
    {
        ManejoMenu manejoMenu = new(); Menu menu = new();
        public void MenuPrincipalVacunacion()
        {

            Console.Clear();
            Console.WriteLine("-- MENU PRINCIPAL VACUNACION --\n\n 0. Volver \n 1. Buscar Vacunacion\n 2. Crear Vacunacion \n 3. Mostrar Vacunaciones");

            int opcion = manejoMenu.LeerOpcionValida(new List<int>() { 0, 1, 2, 3 });

            switch (opcion)
            {
                case 0:
                    {
                        menu.MenuPrincipal();
                        break;
                    }
                case 1:
                    {
                        this.MenuBuscarVacunacion();
                        break;
                    }
                case 2:
                    {
                        this.MenuCrearVacunacion();
                        break;
                    }
                case 3:
                    {
                        this.MenuMostrarVacunacion();
                        break;
                    }
            }
        }

        public void MenuCrearVacunacion()
        {

        }

        public void MenuBuscarVacunacion()
        {

        }

        public void MenuMostrarVacunacion()
        {

        }
        public void MenuEditarVacunacion()
        {

        }
    }
}
