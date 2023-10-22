using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Examen1
{
    internal class Clssubmenu
    {
        int opcion = 0;

        static public void Desplegarsub() 
        {
            int sub = 0;

            do
            {
                
                Console.WriteLine("\n===================");
                Console.WriteLine("Ingrese una opcion: ");
                Console.WriteLine("1- Consultar Empleados");
                Console.WriteLine("2- Listar todos los Empleados Ordenados por Nombre");
                Console.WriteLine("3- Calcular y Mostrar el Promedio de todos los salarios");
                Console.WriteLine("4- Calcular y Mostrar el salario mas alto y el mas bajo de todos los empleados");
                Console.WriteLine("5- Salir");
                Console.WriteLine("6- Volver a menu principal");
                Console.WriteLine("===================\n");
                int.TryParse(Console.ReadLine(), out sub);

                switch (sub)
                {

                    case 1: Clsempleado.Consultar(); break;

                    case 2: Clsempleado.ListaxNombre(); break;

                    case 3: Clsempleado.Promedios(0); break;

                    case 4: Clsempleado.SalarioMayorMenor(); break;

                    case 5: Environment.Exit(0); break;

                    default:
                        break;
                }


            } while (sub != 6);
        }



    }
}
