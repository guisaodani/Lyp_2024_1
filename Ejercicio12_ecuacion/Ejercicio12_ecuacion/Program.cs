using System.Timers;

internal class Program
{
    private static void Main(string[] args)
    {
        //12.	Solicite los parámetros necesarios para resolver una ecuación de 2do grado por medio de la ecuación cuadrática general.
        //El algoritmo retornará las soluciones reales (x1 y x2). Si la ecuación no tiene solución,
        //debe justificar el motivo que no permite resolverla. Pruebe su solución con las siguientes ecuaciones: 
        //	2x^2-5x-3=0
        //  〖0x〗^2+2x-1=0
        //	x^2+x+1=0
        //cuadratica general es ax²+bx+c=0 >>>> X=b± √(b²-4ac))/(2a)

        double a, b, c;
        double x1, x2;
        double y1, y2;
        double raiz;

        //pedirt los valores de a.b.c
        Console.WriteLine("Formula General");

        Console.WriteLine("Ingrese el valor a:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el valor b:");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el valor c:");
        c = double.Parse(Console.ReadLine());

        raiz = (Math.Pow(b, 2) - 4 * (a * c));

        if (raiz < 0)
        {
            Console.WriteLine("El sistema no tiene solucion, no puede haber raices negativas");
             
        }

         
        x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * (a * c)) / 2 * a);
        x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * (a * c)) / 2 * a);

        //mostrar resultado
        Console.WriteLine("");
        Console.WriteLine($"El valor de X1 es: {x1}");
        Console.WriteLine($"El valor de X2 es: {x2}");

        


    
        
    }
}