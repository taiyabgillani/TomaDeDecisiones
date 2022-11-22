using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaDeDecisiones
{
    class Program
    {
        static void Main(string[] args)
        {
            //-Pida dos números y determine el mayor de ellos;
            Console.WriteLine("                                               TOMA DE DESICIONES");
            Console.WriteLine("\n  Pida dos números y determine el mayor de ellos");
            float num;
            float num2;
            Console.WriteLine("Introduzca el primer numero");
            num = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero");
            num2 = float.Parse(Console.ReadLine());
            if (num > num2)
            {
                Console.WriteLine("El numero mayor es " + num);
            }
            else if (num2 == num)
            {
                Console.WriteLine("Estos numeros son iguales");
            }
            else
            {
                Console.WriteLine("El numero mayor es " + num2);
            }

            //-Pida dos sueldos y determine el mayor y el menor de ellos;

            Console.WriteLine("\n  Pida dos sueldos y determine el mayor y el menor de ellos");

            float sueldo;
            float sueldo2;
            Console.WriteLine("Introduzca el primer sueldo");
            sueldo = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo sueldo");
            sueldo2 = float.Parse(Console.ReadLine());
            if (sueldo > sueldo2)
            {
                Console.WriteLine("El sueldo mayor es " + sueldo);
            }
            else  if (sueldo == sueldo2)
            {
                Console.WriteLine("Los dos sueldos son iguales");
            }
            else
            {
                Console.WriteLine("El sueldo mayor es " + sueldo2);
            }



            //- Capture cuatro números determine cuál es el mayor, la sumatoria y el promedio;


            Console.WriteLine("\n    Capture cuatro números determine cuál es el mayor, la sumatoria y el promedio");
            float n1;
            float n2;
            float n3;
            float n4;
            float n5;

            Console.WriteLine("Introdezca el primer numero ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introdezca el segundo numero ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introdezca el tercer numero ");
            n3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introdezca el cuarto numero ");
            n4 = float.Parse(Console.ReadLine());
            n5 = n1;
            if (n5 < n2)
            {
                n5 = n2;
            }
            if (n5 < n3)
            {
                n5 = n3;
            }
            if (n5 < n4)
            {
                n5 = n4;
            }
            Console.WriteLine("El numero mayor es " + n5);
            
            Console.WriteLine("La suma de estos numeros es " + (n1 + n2+ n3 + n4)) ;
            Console.WriteLine("El promedio es " + ((n1 + n2 + n3 + n4)/4));

            // Que capture un número del 0 a 100 y determine la nota literal (A, B+, B-, C+, C-, D, F).
            Console.WriteLine("\n   Que capture un número del 0 a 100 y determine la nota literal (A, B+, B-, C+, C-, D, F ");
            float v1;
            v1 = float.Parse(Console.ReadLine());
            if (v1 >= 0 & v1 < 60)
            {
                Console.WriteLine(" La nota es F");
            }
            else if (v1 >= 60 & v1 < 70)
            {
                Console.WriteLine(" La nota es D");
            }
            else if (v1 >= 70 & v1 < 75)
            {
                Console.WriteLine(" La nota es C-");
            }
            else if (v1 >= 75 & v1 < 80)
            {
                Console.WriteLine(" La nota es C+");
            }
            else if (v1 >= 80 & v1 < 85)
            {
                Console.WriteLine(" La nota es B");
            }
            else if (v1 >= 85 & v1 < 90)
            {
                Console.WriteLine(" La nota es B+");
            }
            else if (v1 >= 90 & v1 <= 100)
            {
                Console.WriteLine(" La nota es A");
            }

            Console.ReadKey();

        }
    }
}
