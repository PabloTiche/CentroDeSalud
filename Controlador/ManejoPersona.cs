using CentroDeSalud.Modelo;
using CentroDeSalud.Vista;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static CentroDeSalud.Controlador.Exceptions;

namespace CentroDeSalud.Controlador
{
    public class ManejoPersona
    {
        Menu menuPrincipal = new(); ManejoMenu manejoMenu = new();

        public List<Persona> ObtenerDatosPersonaDB() 
        {
            List<Persona> personas = null; string baseDatos = "DB/DBPersona.json";

            try
            {
                if (File.Exists(baseDatos)) personas = JsonSerializer.Deserialize<List<Persona>>(File.ReadAllText(baseDatos));
                else personas = new List<Persona>(); 
            }
            catch (JsonException) { Console.WriteLine("\nNo existe nunguna persona en la Base de Datos");}
            catch (Exception ex) { Console.WriteLine($"Ocurrio un error inesperado.\nDetalle: {ex.Message}");}

            return personas;
        }

        private int IngresoDNI()
        {
            bool salir = false; int numeroDNI = 0;    
            do{
                try
                {
                    Console.WriteLine("Ingrese el numero de documento de la persona (sin puntos)");
                    numeroDNI = int.Parse(Console.ReadLine());

                    if (!(numeroDNI >= 1000000 || numeroDNI <= 90000000)) throw new NumeroFueraDeRangoException();
                    else salir = true;

                }
                catch (NumeroFueraDeRangoException ex) {Console.WriteLine(ex.Message);}
                catch (ArgumentNullException){Console.WriteLine("Tiene que ingresar un dato");}  
                catch (FormatException){Console.WriteLine("Tiene que ingresar solo numeros");}
                catch (Exception ex){Console.WriteLine("Ocurrio un error inesperado" + $"DETALLE: {ex.Message}");}
                
            }
            while (!salir);
            return numeroDNI;
        }

        private DateTime IngresoFechaNacimiento()
        {
            bool salir = false; DateTime fechaDeNacimiento = DateTime.Parse("10/10/2000");
            DateTime fechaActual = DateTime.Now; DateTime mayorDeEdad = fechaActual.AddYears(-125);
          
            do{
                try
                {
                    Console.WriteLine("\nIngrese fecha de nacimiento de la persona : (DD/MM/AAAA)");
                    fechaDeNacimiento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("es-AR"));

                    if (fechaDeNacimiento > fechaActual) throw new FechaExcedidaException();
                    else if (fechaDeNacimiento < mayorDeEdad) throw new PersonaConCuraParaLaInmortalidadException();
                    else salir = true;

                }
                catch (FechaExcedidaException ex){Console.WriteLine(ex.Message);}
                catch (PersonaConCuraParaLaInmortalidadException ex){Console.WriteLine(ex.Message);}
                catch (ArgumentNullException){Console.WriteLine("No puede ingresar un dato vacio");}
                catch (Exception ex){Console.WriteLine("Ocurrio un error inesperado" + $"DETALLE: {ex.Message}");}
            }
            while (!salir); return fechaDeNacimiento;
        }

        private Direccion RegistrarDireccion()
        {
            string ciudad, calle, codigoPostal; int altura;
            Provincias provinciaEnum = (Provincias)this.IngresoDeProvincia();

            ciudad = manejoMenu.IngresoString("Ingrese el nombre de la ciudad en la que reside la persona");

            Console.WriteLine("\nIngrese la calle y numero de la residencia de la persona.\n");

            calle = this.IngresoNombreCalle(); altura = this.IngresoNumeroCasa();

            codigoPostal = this.IngresoCodigoPostal();

            return new Direccion(provinciaEnum, ciudad, calle, altura, codigoPostal);
        }

        private int IngresoDeProvincia()
        {
            bool salir = false; int provincia = 1;
            
            do
            {
                try
                {
                    Console.WriteLine("\nSeleccione la provincia en la que reside la persona: "); manejoMenu.MostrarProvincias();
                    provincia = int.Parse(Console.ReadLine());

                    if (provincia < 1 || provincia > 23) throw new ProvinciaEquivocadaException();
                    else salir = true;
  
                }
                catch (ProvinciaEquivocadaException ex){Console.WriteLine(ex.Message);}  
                catch (ArgumentNullException){Console.WriteLine("No se puede ingresar un dato vacio");}   
                catch (FormatException){Console.WriteLine("Ingrese un numero");}
                catch (Exception ex){Console.WriteLine("Ocurrio un error inesperado" + $"DETALLE: {ex.Message}");}
            }
            while (!salir); return provincia;     
        }

        private string IngresoNombreCalle()
        {
            bool salir = false; string nombreCalle = "";

            do{
                try
                {
                    Console.WriteLine("\nIngrese el nombre de la calle en la que vive la persona");
                    nombreCalle = Console.ReadLine();

                    if (String.IsNullOrEmpty(nombreCalle)) throw new DatoVacioException();
                    
                    else if (nombreCalle.Length > 35) throw new StringMuyLargoException();
                    
                    else salir = true;
                         
                }
                catch (DatoVacioException ex){Console.WriteLine(ex.Message);}  
                catch (StringMuyLargoException ex){Console.WriteLine(ex.Message);}
                catch (Exception ex){Console.WriteLine("Ocurrio un error inesperado" + $"DETALLE: {ex.Message}");}
            }
            while (!salir); return nombreCalle;            
        }

        private int IngresoNumeroCasa()
        {
            bool salir = false; int numeroCasa = 69;
            
            do{
                try
                {
                    Console.WriteLine("\nDesea ingresar el numero de casa.");

                    Console.WriteLine("\n1 = SI");
                    Console.WriteLine("\n2 = S/N");
                    int opcion = manejoMenu.LeerOpcionValida(new List<int>() { 1, 2 });

                    switch (opcion)
                    {
                        case 1:
                            {
                                numeroCasa = int.Parse(Console.ReadLine());
                                break;
                            }
                        case 2:
                            {
                                numeroCasa = 0000000001;
                                break;
                            }
                    }

                    if (numeroCasa < 0 || numeroCasa > 20000) throw new NumeroFueraDeRangoException();                 
                    
                    else salir = true;                                                      

                }
                catch (NumeroFueraDeRangoException ex){Console.WriteLine(ex.Message);}                                                   
                catch (ArgumentNullException){Console.WriteLine("No puede ingresar un dato vacio");}
                catch (Exception ex){Console.WriteLine("Ocurrio un error inesperado" + $"DETALLE: {ex.Message}");}
            }
            while (!salir); return numeroCasa;           
        }

        private string IngresoCodigoPostal()
        {
            bool salir = false; string codigoPostal = "";

            do{   
                try
                {
                    Console.WriteLine("\nIngrese el codigo postal:"); codigoPostal = Console.ReadLine();
                    

                    if (codigoPostal.Length > 7) throw new NumeroFueraDeRangoException();                          
                    
                    else salir = true;                                         
                   
                }
                catch (NumeroFueraDeRangoException ex){Console.WriteLine(ex.Message);}
                catch (Exception ex){Console.WriteLine("Ocurrio un error inesperado" + $"DETALLE: {ex.Message}");}
            }
            while (!salir); return codigoPostal;
        }

        private InfoContacto RegistrarInfoContacto()
        {
            Console.Clear();

            Console.WriteLine("Se prodecera a obtener la informacion de contacto de la persona.");

            string correoElectronico = this.IngresoEmail();

            string numeroTelPersonal = this.IngresoNumeroTelefono("\nIngrese el numero de telefono de la persona:");

            string numeroTelEmerg = this.IngresoNumeroTelefono("\nIngrese el numero de telefono de emergencia de la persona:");

            return new InfoContacto(numeroTelPersonal, numeroTelEmerg, correoElectronico);
        }

        private string IngresoEmail()
        {
            string correoElectronico = ""; bool salir = false;
           
            do{
                try
                {
                    Console.WriteLine("\nIngrese el correo electronico de la persona:"); correoElectronico = Console.ReadLine();                

                    if (this.EmailSinErrores(correoElectronico) == false) throw new CorreoNecesitaTodosLosDatosException(); 

                    else salir = true;                         
                   
                }
                catch (CorreoNecesitaTodosLosDatosException ex){Console.WriteLine(ex.Message);}
                catch (Exception ex) { Console.WriteLine("Ocurrio un error inesperado" + $"DETALLE: {ex.Message}"); }
            }
            while (!salir); return correoElectronico;   
        }

        private bool EmailSinErrores(string email)
        {
            string signos;
            signos = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, signos))
            {
                if (Regex.Replace(email, signos, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private string IngresoNumeroTelefono(string mensaje)
        {
            bool salir = false; string numeroTelefono = "";
            
            do{
                try
                {
                    Console.WriteLine(mensaje); numeroTelefono = Console.ReadLine();
                   
                    if (numeroTelefono.Length < 6 || numeroTelefono.Length > 14) throw new NumeroFueraDeRangoException();         
                    
                    else if (Regex.IsMatch(numeroTelefono, @"^[a-zA-Z]+$")) throw new NumeroDeTelefonoConLetrasException();     
                    
                    else salir = true;
                                                              
                }
                catch (NumeroFueraDeRangoException ex){Console.WriteLine(ex.Message);}                                                 
                catch (NumeroDeTelefonoConLetrasException ex){Console.WriteLine(ex.Message);}
                catch (Exception ex) { Console.WriteLine("Ocurrio un error inesperado" + $"DETALLE: {ex.Message}"); }
            }
            while (!salir); return numeroTelefono;        
        }

        public bool BusquedaPorDNI(int ingresoDNI)
        {
            List<Persona> Personas = this.ObtenerDatosPersonaBD();

            bool validacion; bool afirmativo = false;
           
            foreach (Persona persona in Personas)
            {
                if (ingresoDNI == persona.NumeroDNI) validacion = true;
              
                else validacion = false;                                                

                if (validacion == true) afirmativo = validacion;
                                          
            }
            return afirmativo;
        }

        private void MostrarPersonaPorDNI(int dni)
        {
            Menu menu = new();
            Console.Clear();
            Console.WriteLine("Persona en base de datos con ese mismo numero de documento:");

            Persona personaEncontrada = this.ObtenerPersonaPorDNI(dni);

            Console.WriteLine(personaEncontrada.DatosCompletosPersona());

            Console.ReadKey(); Console.Clear();
            menu.MenuPrincipal();
            
        }

        public Persona ObtenerPersonaPorDNI(int dni)
        {
            Persona persona = null;

            try
            {
                List<Persona> personasEnBD = this.ObtenerDatosPersonaBD(); persona = personasEnBD.First(x => x.NumeroDNI == dni);        
            }
            catch (Exception ex) { Console.WriteLine("Ocurrio un error inesperado" + $"DETALLE: {ex.Message}"); }

            return persona;
        }

        public List<Persona> ObtenerDatosPersonaBD()
        {
            List<Persona> personas = null;
            string baseDeDatos = "Almacenamiento/AlmacenamientoPersona.json";

            try
            {
                if (File.Exists(baseDeDatos)) personas = JsonSerializer.Deserialize<List<Persona>>(File.ReadAllText(baseDeDatos));
                         
                else personas = new List<Persona>();
                      
            }
            catch (JsonException){Console.WriteLine("\nNo hay ninguna persona en la base de datos");}
            catch (Exception ex) { Console.WriteLine("Ocurrio un error inesperado" + $"DETALLE: {ex.Message}"); }

            return personas;
        }
    }
}
