using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace P3Examen1
{
    internal class Clsempleado
    {

        // ATRIBUTOS
        static int cantidad = 5;
        static byte indice = 0;
        static int pos = 1;
        static public string[] cedula = new string[cantidad];
        static public string[] nombre = new string[cantidad];
        static public string[] direccion = new string[cantidad];
        static public int[] telefono = new int[cantidad];
        static public float[] salario = new float[cantidad];

        //METODOS
        public static void Inicializar()
        {
            cedula = Enumerable.Repeat("", cantidad).ToArray();
            nombre = Enumerable.Repeat("", cantidad).ToArray();
            direccion = Enumerable.Repeat("", cantidad).ToArray();
            telefono = Enumerable.Repeat(0, cantidad).ToArray();
            salario = Enumerable.Repeat(0f, cantidad).ToArray();
            Console.WriteLine("Arreglos Inicializados");

        }

        public static void Agregar()
        {
            char respuesta;


            do
            {
                Console.Clear();
                Console.WriteLine($"Ingrese su Cedula ({pos}):");
                cedula[indice] = Console.ReadLine();
                Console.WriteLine($"Ingrese su Nombre ({pos}):");
                nombre[indice] = Console.ReadLine();
                Console.WriteLine($"Ingrese su Direccion ({pos}):");
                direccion[indice] = Console.ReadLine();
                Console.WriteLine($"Ingrese su Telefono ({pos}):");
                int.TryParse(Console.ReadLine(), out telefono[indice]);
                Console.WriteLine($"Ingrese su Salario ({pos}):");
                float.TryParse(Console.ReadLine(), out salario[indice]);
                Console.WriteLine("Desea Ingresar otro Empleado (s/n)?");
                respuesta = char.Parse(Console.ReadLine().ToLower());
                switch (respuesta)
                {
                    case 's':


                    case 'n': break;
                    default:
                        Console.WriteLine("\n===================");
                        Console.WriteLine("Opcion Incorrecta");
                        Console.WriteLine("===================\n");
                        respuesta = 'n';
                        break;
                }

                indice++;
                pos++;


            } while (!respuesta.Equals('n'));

            Console.WriteLine("\n===================");
            Console.WriteLine("Empleado agregado");
            Console.WriteLine("===================\n");


        }

        public static void Consultar()
        {
            string ced = "";
            Console.Write("Digite la Cedula: ");
            ced = Console.ReadLine();
            Boolean found = false;

            for (int i = 0; i < cantidad; i++)
            {
                if ((cedula[i]) == ced)
                {
                    Console.WriteLine("\n===================");
                    Console.WriteLine("Datos del empleado\n");
                    Console.WriteLine($"Nombre: {nombre[i]}");
                    Console.WriteLine($"Direccion: {direccion[i]}");
                    Console.WriteLine($"Telefono: {telefono[i]}");
                    Console.WriteLine($"Salario: {salario[i]}");
                    Console.WriteLine("===================\n");
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                Console.WriteLine("\n===================");
                Console.WriteLine("cedula no encontrada");
                Console.WriteLine("===================\n");
                //break;
            }
        }


        public static void Modificar()
        {
            string ced = "";
            Console.Write("Digite la Cedula: ");
            ced = Console.ReadLine();
            for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(cedula[i]))
                {
                    Console.Write("Digite un nombre: ");
                    nombre[i] = Console.ReadLine();
                    Console.Write("Digite la direccion: ");
                    direccion[i] = Console.ReadLine();
                    Console.WriteLine($"Ingrese su Telefono:");
                    int.TryParse(Console.ReadLine(), out telefono[i]);
                    Console.Write("Digite el salario: ");
                    float.TryParse(Console.ReadLine(), out salario[i]);
                    break;
                }
            }

            Console.WriteLine("\n===================");
            Console.WriteLine("Empleado Modificado");
            Console.WriteLine("===================\n");

        }

        public static void Borrar()
        {
            string ced = "";
            Console.Write("Digite la Cedula: ");
            ced = Console.ReadLine();
            for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(cedula[i]))
                {
                    cedula[i] = "";
                    nombre[i] = "";
                    direccion[i] = "";
                    telefono[i] = 0;
                    salario[i] = 0;
                    break;
                }
            }
            Console.WriteLine("\n===================");
            Console.WriteLine("Empleado Eliminado");
            Console.WriteLine("===================\n");
        }

        public static void ListaGeneral()
        {

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Cedula " + " ");

                Console.Write($"Nombre " + " ");

                Console.Write($"Direccion " + " ");

                Console.Write($"Salario " + " \n");


                Console.WriteLine("     " + cedula[i] + "     " + nombre[i] + "     " + direccion[i] + "     " + salario[i]);
                Console.WriteLine(" ");
                //break;

            }

        }

        public static string Promedios(float promedio)
        {

            promedio = salario.Average();
            Console.WriteLine(promedio);
            return " ";

        }


        public static void SalarioMayorMenor()
        {

            float minimo = salario[0];
            float maximo = salario[0];
            for (int i = 0; i < cantidad; i++)
            {
                if (salario[i] > maximo)
                {
                    maximo = salario[i];
                }

                if (salario[i] < minimo && salario[i] != 0)
                {
                    minimo = salario[i];
                }
            }

            Console.WriteLine("el menor de los salarios es: " + minimo);
            Console.WriteLine("el mayor de los salarios es: " + maximo);

        }


        public static void ListaxNombre()
        {
            Array.Sort(nombre);
            Console.WriteLine(string.Join(",",nombre));

        }

    }
}
