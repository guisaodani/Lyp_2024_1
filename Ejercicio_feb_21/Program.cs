using System;

namespace MiprimerAlgoritmo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Realizar un algoritmo que me pida 3 números por pantalla,
            //con el primer número hallar el cuadrado,
            //con el segundo número hallar la raíz cuadrada y con el tercer número hallar la raíz cúbica.
            //Mostrar en pantalla los 3 resultados aritméticos.


            //Declaracion de variables


            double num1, num2, num3;  // o puedes ser int 
            double exp1, squr2, squr3;


            //leer

            Console.WriteLine("Ingrese el primer número");

            num1 = Convert.ToInt32(Console.ReadLine()); //todo lo que ingrese en esta linea sera tomado como string

            Console.WriteLine("Ingrese el segundo numero. Este numero debe ser diferente de 0");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el tercer numero. Este numero deber ser diferente de 0");
            num3 = Convert.ToInt32(Console.ReadLine());

            //Hacer los calculos

            exp1 = Math.Pow(num1, 2);
            squr2 = Math.Pow(num2,.5);
            squr3 = Math.Round(Math.Pow(num3, .3));

           

            //imprimir en pantalla
                
            Console.WriteLine("Exponente= " + num1 + " ^2 " + " = " + exp1);
            Console.WriteLine("Raiz Cuadrada = " + num2 + " ^1/2 " +  " = " + squr2);
            Console.WriteLine("Raiz Cubica = " + num3 + " ^1/3 "+ " = " + squr3);

           




        }
    }
}