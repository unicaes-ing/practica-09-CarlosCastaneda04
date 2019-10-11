using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace practica9
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList frutas = new ArrayList();
            frutas.Add("fresa");
            frutas.Add("Kiwi");
            frutas.Add("Piña");
            frutas.Add("Mandarina");
            frutas.Add("Manzana");
            frutas.Add("Cereza");
            frutas.Add("Naranja");
            frutas.Add("Mango");
            int opcion;
            Console.WriteLine("Menu:");
            Console.WriteLine("[1].Agregar a la lista");
            Console.WriteLine("[2].Mostrar lista");
            Console.WriteLine("[3].Insertar en la lista");
            Console.WriteLine("[4].Eliminar de la lista");
            Console.WriteLine("[5].Buscar en la lista");
            Console.WriteLine("[6].Vaciar lista");
            Console.WriteLine("[7].Salir");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    string fruta;
                    Console.Clear();
                    Console.WriteLine("Ingrese la cantidad de frutas a agregar: ");
                    int cant = int.Parse(Console.ReadLine());
                    int[] agregar = new int[cant];
                    for (int i = 0; i < agregar.Length; i++)
                    {
                        Console.WriteLine("Ingrese el nombre de la fruta: ");
                        fruta = Console.ReadLine();
                        frutas.Add(fruta);
                    }
                    Console.Clear();
                    foreach (string fruit in frutas)
                    {
                        Console.WriteLine(fruit);
                    }
                    break;
                case 2:
                    Console.Clear();
                    foreach (string fruit in frutas)
                    {
                        Console.WriteLine(fruit);
                    }
                    break;
                case 3:
                    Console.Clear();
                    int num;
                    string nuevo;
                    Console.WriteLine("Ingrese el numero segun la lista donde desea ingresar la fruta: ");
                    num = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre de la nueva fruta: ");
                    nuevo = Console.ReadLine();
                    frutas.Insert(num, nuevo);
                    Console.Clear();
                    foreach (string fruit in frutas)
                    {
                        Console.WriteLine(fruit);
                    }
                    break;
                case 4:
                    Console.Clear();
                    int numero;
                    Console.WriteLine("Ingrese el numero de la fruta que desea eliminar: ");
                    numero = int.Parse(Console.ReadLine());
                    frutas.RemoveAt(numero);
                    Console.Clear();
                    foreach (string fruit in frutas)
                    {
                        Console.WriteLine(fruit);
                    }
                    break;
                case 5:
                    Console.Clear();
                    string x;
                    Console.WriteLine("Ingrese el nombre de la fruta que desea buscar: ");
                    x = Console.ReadLine();
                    do
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("La fruta esta en la lista.");
                    } while ((frutas.Contains(x)));
                    break;
                case 6:
                    Console.Clear();
                    frutas.Clear();
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Presione una tecla para salir: ");
                    break;
            }
            Console.ReadKey();
        }
    }
}
