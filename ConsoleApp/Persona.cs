using System;
using System.Collections.Generic;
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
        public Boolean genero { get; set; }

        public  void IngresarDatos() {
            bool ok = true;
            do {
                Console.WriteLine("Ingrese su nombre (Máximo 10 caracteres) :");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su edad (Del 0 al 99) :");
                
                Console.WriteLine("Ingrese su género true=varon  false=mujer :");
                nombre = Console.ReadLine();
                ok = true;
                Console.Read();

            } while (ok);

           
        }
        public void ParseInt(int edade) {
            try {
                edade = int.Parse(Console.ReadLine());
            }
            catch (ArgumentException e) {
            
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



    }
}
