internal class Program
{
    private static void Main(string[] args)
    {
        //9.	Construir un programa que pida por pantalla 3 números
        //y luego diga cuál es el mayor de los números ingresados.

        double num1, num2, num3;


        Console.Write("Ingrese los numeros a comparar \n");

        Console.WriteLine("\nIngrese el primer numero: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nIngrese el segundo numero: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nIngrese el tercer numero: ");
        num3 = Convert.ToDouble(Console.ReadLine());

      // if(((num1>num2) && (num1> num3)) || (num2>num1 && (num2>num3)) || (num3>num1 && (num3>num2)))
       //Console.WriteLine("El numero mayor es " );
        

        if ((num1 > num2) && (num1 > num3))

        {
            Console.WriteLine("El numero mayor es "+ num1);

        }
          if ((num2 > num1) && (num2 > num3))
        {
            Console.WriteLine("El numero mayor es " + num2);
        }
           if ((num3 > num1) && (num3 > num2))
        {
            Console.WriteLine("El numero mayor es " + num3);
        }





    }
}