using CentroDeSalud.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeSalud.Vista
{
    internal class MenuVacuna
    {
        ManejoMenu manejoMenu = new(); Menu menu = new();
        public void MenuPrincipalVacuna()
        {
            Console.Clear(); Console.WriteLine("-- MENU VACUNACION --\n");
            Console.WriteLine("0. Volver \n 1. Buscar Vacuna \n 2. Crear Vacuna \n 3. Agregar Vacunacion ");

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
                        this.MenuBuscarVacuna();
                        break;
                    }
                case 2:
                    {
                        this.MenuCrearVacuna();
                        break;
                    }
                case 3:
                    {
                        this.MenuMostrarVacunas();
                        break;
                    }
            }
        }

        public void MenuCrearVacuna()
        {

        }

        public void MenuBuscarVacuna()
        {

        }

        public void MenuMostrarVacunas()
        {

        }

        public void MenuEditarVacuna()
        {

        }
    }
}
