internal class Program
{
    private static void Main(string[] args)
    {
        //11.	Construir un algoritmo que pida N números por pantalla, cuando el usuario ingrese un número negativo,
        //el programa debe finalizar y
        //mostrar en consola la cantidad total de números positivos que ingresó hasta antes de ingresarse el número negativo.

        int n,cantidadnum = 0;
        Console.WriteLine("Ingresa un numero y negativos: ");



        {
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            if (n >= 0)
            {
                Console.Write(n);
            }

            if(n < 0)
            {
                cantidadnum = n++;

            }

            Console.WriteLine($"La cantidad de positivos es {cantidadnum}");


        }
    }
}