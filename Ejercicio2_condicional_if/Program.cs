using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //2.	Lea la longitud de tres segmentos y que muestre si se puede construir un triángulo con estos segmentos.

        //declaracion de variables

        double seg1,seg2,seg3;
        string mensaje = "Se puede contruir el triangulo";

        // pedir los datos

        Console.Write("SEGMENTOS POSITIVOS\n ");

        Console.WriteLine("\nIngrese el primer segmento: ");
        seg1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nIngrese el segundo segmento: ");
        seg2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nIngrese el tercer segmento: ");
        seg3 = Convert.ToDouble(Console.ReadLine());

        //validar

        //cod mas senior

        if (((seg1 + seg2) > seg3) && ((seg1 + seg3) > seg2) && ((seg2 + seg3) > seg1))
        {
            Console.WriteLine(string.Format("1Si {0}", mensaje));
        }
        else
        {
            Console.WriteLine(string.Format("1No {0}", mensaje));

        }

        //otra forma mas largar mas junior
        if ((seg1 + seg2) > seg3)
            if ((seg1 + seg3) > seg2)
                if ((seg2 + seg3) > seg1)
                {
                    Console.WriteLine(string.Format("2Si {0}", mensaje));
                }
                else
                {
                    Console.WriteLine(string.Format("2NO {0}", mensaje));
                }
            else
            {
                Console.WriteLine(string.Format("2NO {0}", mensaje));
            }
        else 
        {
            Console.WriteLine(string.Format("2NO {0}", mensaje));
        }


    }
}