using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeSalud.Controlador
{
    public class ManejoMenu
    {
        public int LeerOpcionValida(List<int> opcionesValidas)
        {
            int selecc = -1;
            try
            {
                while (!opcionesValidas.Contains(selecc))
                {
                    selecc = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }


            return selecc;
        }


    }
}
