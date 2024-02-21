using System;

namespace MiprimerAlgoritmo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //Ingresar por pantalla 2 números y calcular las 4 operaciones aritméticas con dichos números.
            //Imprimir en pantalla el resultado de cada operación.mostrar en pantalla mensaje de advertencia que el 
            // segundo numero debe ser diferente de 0. imprimir en pantalla el resultado de la operacion


            //Declaracion de variables

            
            double num1, num2;  // o puedes ser int 
            double sum, rest, prod, coc;


            //leer

            Console.WriteLine("Ingrese el primer número");

            num1= Convert.ToInt32(Console.ReadLine()); //todo lo que ingrese en esta linea sera tomado como string

            Console.WriteLine("Ingrese el segundo numero. Este numero debe ser diferente de 0");
            num2= Convert.ToInt32(Console.ReadLine());

            //Hacer los calculos

            sum = num1+ num2;
            rest = num1 - num2;
            prod = num1 * num2;
            coc = num1 / num2;

            //imprimir en pantalla

            Console.WriteLine("Suma = " + num1 + " + " +  num2 + " = " + sum);
            Console.WriteLine("Resta = " + num1 + " - " + num2 + " = " + rest);
            Console.WriteLine("multiplicacion = " + num1 + " * " + num2 + " = " + prod);
            Console.WriteLine("Cociente = " + num1 + " / " + num2 + " = " + coc);
                



        }
    }
}
