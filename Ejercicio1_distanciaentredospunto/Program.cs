using System;

namespace Ejercicio1_distanciaentredospunto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.	Lea las coordenadas de dos puntos y que muestre la  distancia entre los dos puntos.

            //datos de entrada. 4 variables
            //declaracion de variables

            double X1,X2,Y1,Y2, distancia;
          

            //solicitud de datos:

            Console.WriteLine("Digita el valor de X1:  ");
            X1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digita el valor de Y1:  ");
            Y1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digita el valor de X2:  ");
            X2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digita el valor de Y2:  ");
            Y2 = double.Parse(Console.ReadLine());

            //proceso y calculo

            distancia = Math.Sqrt((Math.Pow(X2-X1, 2)) + (Math.Pow(Y2-Y1, 2)));

            //imprimir salida
            Console.WriteLine("La distancia entre los puntos es ("+ X1 + "," + Y1 +" ) y ("+ X2 + "," + Y2 + ") es = " 
                + distancia );

            //otra forma de imprimir y otra forma de truncar y aproximar

            Console.WriteLine(String.Format("la distancia entre los pares ordenados ({0},{1}) y ({2},{3}) es =  {4}"
                , X1 ,Y1, X2, Y2, distancia.ToString("N2")));

            


        }
    }
}
