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
            Loger("Se mostró todo los datos", true);
            Console.Read();
        }
        public void ParseInt(int edade)
        {
            string msj;
            bool ok = false;
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
                msj = "Se ingresó la Edad";
                Loger(msj, true);
            }
            catch (IOException e)
            {
                msj = "Ocurrio un Error:" + e.Message;
                Console.WriteLine(msj);
                Loger(msj, false);
                errorok = true;

            }
            catch (OutOfMemoryException e)
            {
                msj = "Ocurrio un Error:" + e.Message;
                Console.WriteLine(msj);
                Loger(msj, false);
                errorok = true;
            }
            catch (ArgumentOutOfRangeException e)
            {
                msj = "Ocurrio un Error:" + e.Message;
                Console.WriteLine(msj);
                Loger(msj, false);
                errorok = true;
            }
            catch (ArgumentNullException e)
            {
                msj = "Ocurrio un Error:" + e.Message;
                Console.WriteLine(msj);
                Loger(msj, false);
                errorok = true;
            }
            catch (FormatException e)
            {
                msj = "Ocurrio un Error:" + e.Message;
                Console.WriteLine(msj);
                Loger(msj, false);
                errorok = true;
            }

            catch (OverflowException e)
            {
                msj = "Ocurrio un Error:" + e.Message;
                Console.WriteLine(msj);
                Loger(msj, false);
                errorok = true;
            }
            catch (Exception e)
            {
                msj = "Ocurrio un Error:" + e.Message;
                Console.WriteLine(msj);
                Loger(msj, false);
                errorok = true;
            }

        }
        public void ParseString(string str)
        {   
            bool ok= false;
            string msj;
            try
            {
                do
                {
                    ok = false;
                    Console.WriteLine("Ingrese su nombre (Máximo 10 caracteres) :");
                    str = Console.ReadLine();
                    if(str.Length>10 || str.Length<1)
                    {
                        ok= true;
                    }
                }while (ok);
                nombre = str;
                msj = "Se ingresó el nombre";
                Loger(msj, true);
            }
            catch (IOException e)
            {
                msj = "Ocurrio un Error:" + e.Message;
                Console.WriteLine(msj);
                Loger(msj, false);
                errorok = true;
            }
            catch (OutOfMemoryException e)
            {
                msj = "Ocurrio un Error:" + e.Message;
                Console.WriteLine(msj);
                Loger(msj, false);
                errorok = true;
            }
            catch (ArgumentOutOfRangeException e)
            {
                msj = "Ocurrio un Error:" + e.Message;
                Console.WriteLine(msj);
                Loger(msj, false);
                errorok = true;
            }
            catch (Exception e)
            {
                msj = "Ocurrio un Error:" + e.Message;
                Console.WriteLine(msj);
                Loger(msj, false);
                errorok = true;
            }



        }
    
        public void Parsebool(bool b)
        {
            string msj;
            try
            {
                Console.WriteLine("Ingrese su género true=varon  false=mujer :");

                b = bool.Parse(Console.ReadLine());
                genero = b;
                msj = "Se ingresó la el genero";
                Loger(msj, true);
            }
            catch (ArgumentNullException e)
            {
                msj = "Ocurrio un Error:" + e.Message;
                Console.WriteLine(msj);
                Loger(msj, false);
                errorok = true;
            }
            catch (FormatException e)
            {
                msj = "Ocurrio un Error:" + e.Message;
                Console.WriteLine(msj);
                Loger(msj, false);
                errorok = true;
            }
            catch (IOException e)
            {
                msj = "Ocurrio un Error:" + e.Message;
                Console.WriteLine(msj);
                Loger(msj, false);
                errorok = true;
            }
            catch(OutOfMemoryException e)
            {
                msj = "Ocurrio un Error:" + e.Message;
                Console.WriteLine(msj);
                Loger(msj, false);
                errorok = true;
            }
            catch (ArgumentOutOfRangeException e)
            {
                msj = "Ocurrio un Error:" + e.Message;
                Console.WriteLine(msj);
                Loger(msj, false);
                errorok = true;
            }
            catch (Exception e)
            {
                msj = "Ocurrio un Error:" + e.Message;
                Console.WriteLine(msj);
                Loger(msj, false);
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
        public void Loger(string msj, bool ok)
        {
            DateTime fecha = DateTime.Today;
            string Fecha = fecha.ToString("d");
            string[] fect = Fecha.Split('/');
            Fecha = (fect[2] + fect[1] + fect[0]);
            Log.Logger = new LoggerConfiguration().WriteTo.File("Log_" + Fecha + ".txt").CreateLogger();
            if (ok)
            {
                Log.Information(msj);
            }
            else
            {
                Log.Error(msj);
            }
            Log.CloseAndFlush();
        }
    }

   

}
