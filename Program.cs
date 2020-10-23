using System;
using System.Collections.Generic;

namespace pruebaConsola
{
    class Program
    {        
        static void Main(string[] args)
        {            
            Console.WriteLine("Hola!");
            Console.WriteLine("Cómo te llamás?");

            //string nombre = "Julieta";
            /*
            Comentario multilinea
            */
            string nombre = Console.ReadLine();
            
            //Console.WriteLine("Hola " + nombre);
            Console.WriteLine(ConcatenarTexto("Hola ", nombre));            
            Console.WriteLine("Cuántos años tenés?");
            string edadTexto = Console.ReadLine();
            int edad = Convert.ToInt32(edadTexto);
            Console.WriteLine($"Tenés {edad} años");            


            List<string> colores = new List<string>();
            colores.Add("Azul");
            colores.Add("Blanco");
            colores.Add("Rojo");

            List<string> talles = new List<string>{ "XS", "S", "M", "L", "XL" };

            foreach(string color in colores)
            {
                //Console.WriteLine(color);
                MostrarEnConsola(color);
            }
            /*for(int i=0; i<colores.Count; i++)
            {
                Console.WriteLine(colores[i]);
            }*/
        }

        static void MostrarEnConsola(string textoParaMostrar)
        {
            Console.WriteLine(textoParaMostrar);
        }

        static void MostrarEnConsola(int numeroParaMostrar)
        {
            Console.WriteLine(numeroParaMostrar.ToString());
        }

        static string ConcatenarTexto(string texto1, string texto2)
        {
            return texto1 + texto2;
        }
    }
}
