﻿using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;

internal class Program
{
    private static void Main(string[] args)
    {
        /* 21.Se quiere crear un algoritmo en C# que calcule el IMC de N pacientes y luego lo clasifique dentro de una categoría:

      -Si el IMC del paciente es menor a 18,5, entonces tiene peso insuficiente.
      -Si el IMC está entre 18,5 y 24,9 se encuentre en la categoría de Peso Saludable
      -Si el IMC está entre 25,0 y 29,9 entonces tiene sobrepeso
      - Si el IMC es mayor de 29.9 entonces tiene obesidad.

       Mostrar en pantalla la categoría de cada uno de los pacientes.La aplicación debe estar en capacidad de pedirle al usuario si quiere volver a calcular */

        //IMC=peso/estaturá al cuadrado

        Double estatura, imc,peso, Npacientes;
        while (true)

       

        do
        {   
            Console.Clear();
            Console.WriteLine("*****************INDICE DE MASA CORPORAL***********************");
            Console.WriteLine("|                 Datos de las personas                         |");


            
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese los siguientes datos");
            Console.WriteLine("Ingrese el peso: ");
            peso = Double.Parse(Console.ReadLine()); 
            Console.ReadKey(); //para sostener el programa

            Console.WriteLine("Ingrese la estartura en CM: ");
            estatura = Double.Parse(Console.ReadLine());

            Console.ReadKey(); //para sostener el programa
            Console.WriteLine("...");

            imc = (peso / (Math.Pow(estatura, 2)));
            Console.WriteLine($"La persona tiene un IMC de: {imc}");



            if (imc < 18.5)

            {
                Console.WriteLine("La persona se encuentra en: Peso Insuficiente");
                    Console.ReadKey(); //para sostener el programa

                }
              else if (imc >= 18.5 && imc <= 24.9)
              {
                Console.WriteLine("La persona se encuentra en: Peso Saludable");
                    Console.ReadKey(); //para sostener el programa
                }

              else if (imc >= 25.0 && imc <= 29.9)
               {
                Console.WriteLine("La persona se encuentra en: Sobrepeso");
                    Console.ReadKey(); //para sostener el programa
                }

              else
                Console.WriteLine("La persona se encuentra en: Obesidad");
                Console.ReadKey(); //para sostener el programa

            }
        while(true);//mientras la operacion se realice el volver a pedir los datos



    }
}