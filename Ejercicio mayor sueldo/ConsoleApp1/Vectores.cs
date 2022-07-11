using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Vectores

    {
        private string[] Nombres;
        private int[] Sueldos;

        public void cargar()
        {
            Nombres = new string[6];
            Sueldos = new int[6];
            for (int i = 0; i < Nombres.Length; i++)
            {
                Console.WriteLine("Ingrese nombre del empleado: ");
                Nombres[i] = Console.ReadLine();
                Console.WriteLine("Ingrese su sueldo: ");
                Sueldos[i] = int.Parse(Console.ReadLine());

            }
        }
        public void MayorSueldo()
        {
            float mayor = Sueldos[0];
            int posicion = 0;
            

            for(int i = 0; i < Nombres.Length; i++)
            {
                if (Sueldos[i] > mayor)
                {
                    mayor = Sueldos[i];
                    posicion = i;
                }
            }
            Console.WriteLine("El empleado con mayor sueldo es: " + Nombres[posicion]);
            Console.WriteLine("Con un sueldo de: "+ mayor);
        }
        
        
     
    }
}
