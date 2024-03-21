internal class Program
{
    private static void Main(string[] args)
    {
        //16.	Elabora un algoritmo que imprima los números del 1 al 100. Que calcule la suma de todos los números pares por un lado, y por otro, la de todos los impares.
        int  sumadoPar=0, sumadoImpar=0;

        for (int i = 0; i <=100; i++) 
        {
            //mostrar los numeros
            Console.WriteLine(i);

            //indentificar los numeros pares e impares
            if (i % 2 == 0)
            {
                sumadoPar += i;
            }
            else if (i % 2 != 0) 
            {
                sumadoImpar += i;
            }           
        }
        Console.WriteLine(sumadoPar);
        Console.WriteLine(sumadoImpar);
    }
}