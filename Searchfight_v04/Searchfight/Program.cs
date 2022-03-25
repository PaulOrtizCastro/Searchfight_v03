using Searchfight.Configuracion;
using Searchfight.Factory;
using Searchfight.Motores;
using Searchfight.Servicios;
using System;
using System.Collections.Generic;

namespace Searchfight
{
    class Program
    {
        static void Main(string[] args)
        {
            //Principios SOLID: Principio de Responsabilidad Única.
            //Principios SOLID: Abierto/Cerrado. Abierto para su extensión pero cerrado para su modificación.
            //Principios SOLID: Liskov LSP, Jerarquización de clases

            //Si se requiere solicitar variables al usuario.
            //string p1 = "";
            //string p2 = "";

            //Console.Write("Igrese primera palabra: ");
            //p1 = Console.ReadLine();
            //list.Add(p1);
            //Console.Write("Igrese segunda palabra: ");
            //p2 = Console.ReadLine();
            //list.Add(p2);
            //args = list.ToArray();

            //string[] array = { ".NET", "java script" };
            //args = array; 
            //Console.Write("***Leyendo variables*****");
            //Console.Write("\n");
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter a query to search....");
                args = Console.ReadLine()?.Split(' ');
            }


            if (args.Length >= 2)
            {
                ISearchServiceFactory factory = new BuscarConfiguracionServicio();
                BuscarServicio[] arrayServices = factory.obtenerServicios();

                foreach (string arg in args) {
                    Console.Write("\n");
                    Console.Write($"{arg}: ");
                    Console.Write("\n");

                    foreach (BuscarServicio service in arrayServices)
                    {
                        string result = service.GetResults(arg);
                        Console.Write($"{result} ");
                    }
                }
                Console.Write("\n");
                Console.Write("********");
                Console.Write("\n");
                foreach (BuscarServicio service in arrayServices)
                {
                    Console.WriteLine(service.WinnerToString());
                }
                Console.Write("\n");
                Console.Write("********");
                Console.Write("\n");
                Console.Write("\n");
                Console.WriteLine($"Total winner: {factory.obtenerGanador(arrayServices)}");
                Console.Write("\n");
                Console.Write("***Fin*****");
            }
            else { 
                Console.WriteLine("Por favor ingresar por lo menos el nombre de dos plataformas a comparar.");
            }
            Console.Write("\n\n\n");
        }
    }
}
