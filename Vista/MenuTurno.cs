using CentroDeSalud.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeSalud.Vista
{
    internal class MenuTurno
    {
        ManejoMenu manejoMenu = new(); Menu menu = new();
        public void MenuPrincipalTurno()
        {
            Console.Clear();
            Console.WriteLine("-- MENU PRINCIPAL TURNOS --\n\n 0. Volver \n 1. Buscar Turno\n 2. Crear Turno \n 3. Mostrar Turnos");

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
                        this.MenuBuscarTurno();
                        break;
                    }
                case 2:
                    {
                        this.MenuCrearTurno();
                        break;
                    }
                case 3:
                    {
                        this.MenuMostrarTurnos();
                        break;
                    }
            }

        }

        public void MenuBuscarTurno()
        {

        }

        public void MenuCrearTurno()
        {

        }

        public void MenuMostrarTurnos()
        {

        }

        public void MenuEditarTurno()
        {

        }
    }
}
