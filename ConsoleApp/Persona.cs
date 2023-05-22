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

        public void IngresarDatos()
        {               
                ParseString(nombre);
                ParseInt(edad);
                //Parsebool(genero);
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
            }
            catch (IOException e)
            {

            }
            catch (OutOfMemoryException e)
            {
            }
            catch (ArgumentOutOfRangeException e)
            {

            }
            catch (ArgumentNullException e)
            {

            }
            catch (FormatException e)
            {

            }

            catch (OverflowException e)
            {

            }
            catch (Exception e)
            {

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
                    if(str.Length>10 || str.Length <= 0)
                    {
                        ok= true;
                    }
                }while (ok);
            }
            catch (IOException e)
            {

            }
            catch (OutOfMemoryException e)
            {
            }
            catch (ArgumentOutOfRangeException e)
            {
            }
            catch (Exception e)
            {

            }



        }
    
        public void Parsebool(bool b)
        {
            try
            {
                Console.WriteLine("Ingrese su género true=varon  false=mujer :");

                b = bool.Parse(Console.ReadLine());
            }
            catch (ArgumentNullException e)
            {

            }
            catch (FormatException e)
            {

            }
            catch (IOException e)
            {

            }
            catch(OutOfMemoryException e)
            {

            }
            catch (ArgumentOutOfRangeException e)
            {

            }
        }
    }

}
