using System.Timers;

internal class Program
{
    private static void Main(string[] args)
    {
        //10.	Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor,
        //el del medio y el menor de los números ingresados.

        double n1,n2,n3;

        Console.Write("INGRESA TRES NUMEROS \n");

        Console.WriteLine("\n Ingresa el primer numero: ");
        n1= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n Ingresa el segundo numero numero: ");
        n2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n Ingresa el tercer numero: ");
        n3 = Convert.ToDouble(Console.ReadLine());

        if ((n1 > n2) && (n2 > n3))
        {
            Console.WriteLine($"El num mayor es:  {n1}, El numero de medio es:  {n2},  y el numero menor es:  {n3}");
        }
        else if ((n2 > n3) && (n3 > n1))
        {
            Console.WriteLine($"El num mayor es:  {n2}, El numero de medio es:  {n3},  y el numero menor es:  {n1}");
        }


        else if ((n3 > n1) && (n1 > n2))
        {
            Console.WriteLine($"El num mayor es:  {n2},El numero de medio es:  {n1},  y el numero menor es:  {n2}");
        }

        Console.WriteLine("Hay numeros iguales");

    }
}