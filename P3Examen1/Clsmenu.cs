using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Examen1
{
    internal class Clsmenu
    {

        int opcion = 0; //variable global

        public void desplegar()
        {
            do
            {
               
                Console.WriteLine("\n===================");
                Console.WriteLine("Ingrese una opcion: ");
                Console.WriteLine("1- Agregar Empleados");
                Console.WriteLine("2- Consultar Empleados");
                Console.WriteLine("3- Modificar Empleados");
                Console.WriteLine("4- Borrar Empleados");
                Console.WriteLine("5- Inicializar Arreglos");
                Console.WriteLine("6- Submenu de Reportes");
                Console.WriteLine("7- Salir");
                Console.WriteLine("===================\n");
                int.TryParse(Console.ReadLine(),out opcion);

                switch (opcion)
                {

                    case 1: Clsempleado.Agregar(); break;

                    case 2: Clsempleado.Consultar(); break;  

                    case 3: Clsempleado.Modificar(); break;

                    case 4: Clsempleado.Borrar(); break;

                    case 5: Clsempleado.Inicializar(); break;  

                    case 6: Clssubmenu.Desplegarsub(); break;  
                    
                    case 7: Environment.Exit(0); break;
                    
                    default:
                        break;
                }


            } while (opcion !=8);
        
        
        }


    }
}
