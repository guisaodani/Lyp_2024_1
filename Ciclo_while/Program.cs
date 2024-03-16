using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        //13.	Construir un algoritmo que pida N números por pantalla, cuando el usuario ingrese un número negativo, el programa debe finalizar y mostrar en consola la cantidad total de números positivos que ingresó hasta antes de ingresarse el número negativo.
        //numbrar var;iable

        //int N, contador = 0;
        //bool validador = true;

        ////ciclo, mientras validador sea true el ciclo se va a repetir
        //while (validador == true)
        //{
        //    Console.Write("Ingrese un numero: ");
        //    N = Convert.ToInt32(Console.ReadLine());

        //    if (N < 0) { validador = false; }
        //    else { contador = contador + 1; }
        //}
        //Console.WriteLine($"cantidad de numero positivos {contador}");

        //Otra forma

        int num, cont = 0;

        while (true)
        {
            Console.WriteLine("Ingrese un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)

            {
                break;  //ya no cuenta mas y pasa al resultado
            }
            else
            {
                cont = cont + 1;
            }

            
        }
        Console.WriteLine($"Total numero positivos {cont}");
    }


}

