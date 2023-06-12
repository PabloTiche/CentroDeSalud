using CentroDeSalud.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeSalud.Vista
{
    internal class MenuFormulario
    {
        ManejoMenu manejoMenu = new(); Menu menu = new();
        public void MenuPrincipalFormulario()
        {

            Console.Clear();
            Console.WriteLine("-- MENU PRINCIPAL FORMULARIO --\n\n 0. Volver \n 1. Buscar Formulario\n 2. Crear Formulario \n 3. Mostrar Formularios");

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
                        this.MenuBuscarFormulario();
                        break;
                    }
                case 2:
                    {
                        this.MenuCrearFormulario();
                        break;
                    }
                case 3:
                    {
                        this.MenuMostrarFormularios();
                        break;
                    }
            }
        }

        public void MenuCrearFormulario()
        {

        }

        public void MenuBuscarFormulario()
        {

        }

        public void MenuMostrarFormularios()
        {

        }
        public void MenuEditarFormulario()
        {

        }
    }
}
