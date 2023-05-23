using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{


    internal class Persona
    {

        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.IngresarDatos();



        }


        //Log= new LoggerConfiguration(Write)
        public string nombre { get; set; }
        public int edad { get; set; }
        public bool genero { get; set; }

        public bool errorok=false;

        public void IngresarDatos()
        {               
                ParseString(nombre);
                ComprobarFinalizar();
                ParseInt(edad);
                ComprobarFinalizar();
                Parsebool(genero);
                ComprobarFinalizar();
            if (genero)
            {
                Console.WriteLine("Hola " + nombre + ", " + edad + " años, género masculino");
            }else { 
                Console.WriteLine("Hola " + nombre + ", " + edad + " años, género femenino"); 
            }
            Console.Read();
        }
        public void ParseInt(int edade)
        { bool ok = false;
            try
            {
                do
                {
                    ok = false;
                    Console.WriteLine("Ingrese su edad (Del 0 al 99) :");
                    edade = int.Parse(Console.ReadLine());
                    if(edade<0 || edade > 99)
                    {
                        ok = true;
                    }
                } while (ok);
                edad = edade;
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocurrio un Error:" + e.Message);
                errorok = true;

            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine("Ocurrio un Error:" + e.Message);
                errorok = true;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Ocurrio un Error:" + e.Message);
                errorok = true;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Ocurrio un Error:" + e.Message);
                errorok = true;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Ocurrio un Error:" + e.Message);
                errorok = true;
            }

            catch (OverflowException e)
            {
                Console.WriteLine("Ocurrio un Error:" + e.Message);
                errorok = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocurrio un Error:" + e.Message);
                errorok = true;
            }

        }
        public void ParseString(string str)
        { bool ok= false;
            try
            {
                do
                {
                    ok = false;
                    Console.WriteLine("Ingrese su nombre (Máximo 10 caracteres) :");
                    str = Console.ReadLine();
                    if(str.Length>10)
                    {
                        ok= true;
                    }
                }while (ok);
                nombre = str;
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocurrio un Error:" + e.Message);
                errorok = true;
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine("Ocurrio un Error:" + e.Message);
                errorok = true;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Ocurrio un Error:" + e.Message);
                errorok = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocurrio un Error:" + e.Message);
                errorok = true;
            }



        }
    
        public void Parsebool(bool b)
        {
            try
            {
                Console.WriteLine("Ingrese su género true=varon  false=mujer :");

                b = bool.Parse(Console.ReadLine());
                genero = b;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Ocurrio un Error:"+ e.Message);
                errorok = true;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Ocurrio un Error:" + e.Message);
                errorok = true;
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocurrio un Error:" + e.Message);
                errorok = true;
            }
            catch(OutOfMemoryException e)
            {
                Console.WriteLine("Ocurrio un Error:" + e.Message);
                errorok = true;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Ocurrio un Error:" + e.Message);
                errorok = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocurrio un Error:" + e.Message);
                errorok = true;
            }
        }

        public void ComprobarFinalizar()
        {
            if (errorok)
            {
                Console.Read();
                Environment.Exit(0);
            }
        }
    }

}
