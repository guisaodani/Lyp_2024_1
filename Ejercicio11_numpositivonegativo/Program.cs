using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        //11.	Construir un algoritmo que pida N números por pantalla, cuando el usuario ingrese un número negativo,
        //el programa debe finalizar y mostrar en consola la cantidad total de números
        //positivos que ingresó hasta antes de ingresarse el número negativo.


        int[] cantidadnumeros = new int[5];
        int numpositivo = 0;
        int numnegativo = 0;

        for (int i = 0; i < cantidadnumeros.Length; i++)
        {
            Console.WriteLine("ingresa el numero " + (i + 1));
            cantidadnumeros[i] = Convert.ToInt32(Console.ReadLine());

        }
        for (int i = 0; i < cantidadnumeros.Length; i++)
        {
            if (cantidadnumeros[i] < 0)
            {
                numnegativo++;
            }
            else
            {

            }





        }

        Console.WriteLine($"cantidad de negativos {numnegativo}");

        //



        {
            int cantidadNumerosPositivos = 0;

            while (true)
            {
                Console.Write("Ingrese un número (para terminar ingrese un negativo): ");
                double numero = double.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    break;
                }

                if (numero > 0)
                {
                    cantidadNumerosPositivos++;
                }
            }

            Console.WriteLine("La cantidad total de números positivos ingresados es: " + cantidadNumerosPositivos);
        }
    }

}


}

      




        





            

           

        
                




        

        


    
    
    
