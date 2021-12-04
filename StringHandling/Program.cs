using System;

namespace StringHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cómo lidiar con textos en C#");
            Console.WriteLine("============================");
            var listaPalabras = new string[] { "Hola", "mundo" };

            StringHandling stringHandling = new StringHandling();

            Console.WriteLine(stringHandling.Concatenacion(listaPalabras));
            Console.WriteLine(stringHandling.Formateo(listaPalabras));
            Console.WriteLine(stringHandling.Interpolacion(listaPalabras));
            Console.ReadLine();
        }        
    }

    public class StringHandling
    {
        public string Concatenacion(string[] palabras)
        {
            var palabra1 = palabras[0];
            var palabra2 = palabras[1];

            return "Usando concatenación: " + palabra1 + " " + palabra2;
        }

        public string Formateo(string[] palabras)
        {
            var palabra1 = palabras[0];
            var palabra2 = palabras[1];

            return string.Format("{0}: {1} {2}","Usando formateo", palabra1, palabra2);
        }

        public string Interpolacion(string[] palabras)
        {
            var palabra1 = palabras[0];
            var palabra2 = palabras[1];

            return $"Usando interpolación: {palabra1} {palabra2}";
        }
    }
}
