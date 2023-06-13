using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeSalud.Controlador
{
    internal class Exceptions
    {
        public class DatoVacioException : ArgumentNullException
        {
            public DatoVacioException() : base("No puede ingresar un dato vacio. ") { }
        }

        public class NumeroFueraDeRangoException : Exception 
        {
            public NumeroFueraDeRangoException() : base("Necesita un numero dentro de un rango valido. ") { }
        }

        public class SoloLetrasException : Exception
        {
            public SoloLetrasException() : base("Solo puede ingresar palabras o letras. ") { }
        }

        public class FechaExcedidaException : Exception
        {
            public FechaExcedidaException() : base("No puede ingresar un fecha mayor a la actual. ") { }
        }

        public class PersonaConCuraParaLaInmortalidadException : Exception
        {
            public PersonaConCuraParaLaInmortalidadException() : base("Biologicamente es imposible que persona ingresada siga viva. ") { }
        }

        public class ProvinciaEquivocadaException : Exception
        {
            public ProvinciaEquivocadaException() : base("Ingrese un dato acorde a los mostrados anteriormente"){}
        }

        public class PersonaEquivocadaException : Exception
        {
            public PersonaEquivocadaException() : base("Ingrese datos acorde a la persona seleccionada. ") { }
        }

        public class CompletarTodosLosDatosException : Exception
        {
            public CompletarTodosLosDatosException() : base("Complete los datos solicitados. ") { }
        }

        public class NumeroDeTelefonoConLetrasException : Exception
        {
            public NumeroDeTelefonoConLetrasException() : base("Al momento de ingresar un nuemro de telefono solo ingrese numeros. ") { }
        }

        public class StringMuyLargoException : Exception
        {
            public StringMuyLargoException() : base("Ingrese un texto que no exceda los 25 caracteres. ") { }
        }

        public class SegundaFechaMenor : Exception 
        {
            public SegundaFechaMenor() : base("Al momento de ingresar la segunda fecha, ésta no puede ser anterior a la primera. ") { }
        }
        public class CorreoNecesitaTodosLosDatosException : Exception
        {
            public CorreoNecesitaTodosLosDatosException() : base("El correo ingresado necesita tener todos los datos requeridos '@', '.'"){}
            
        }
    }
}
