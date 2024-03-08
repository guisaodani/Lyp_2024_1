using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        //11.	La pizzería Bella Napoli ofrece pizzas vegetarianas y no vegetarianas a sus clientes. Los ingredientes para cada tipo de pizza aparecen a continuación.
        //•	Ingredientes vegetarianos: Pimiento y tofu.
        //•	Ingredientes no vegetarianos: Peperoni, Jamón y Salmón.

        //Escribir un programa en C# que pregunte al usuario si quiere una pizza vegetariana 	o no, y en función de su respuesta le muestre un menú con los ingredientes 		disponibles para que elija. Solo se puede elegir un ingrediente además de la 		mozzarella y el tomate que están en todas las pizzas. Al final se debe mostrar por 	pantalla si la pizza elegida es vegetariana o no y todos los ingredientes que lleva.

        Console.Write("\n*****************PIZZERIA BELLA NAPOLI****************");
        Console.Write("\n");

        string respuesta1, respuesta2;

        Console.WriteLine("\n¿quiere pizza vegetariana o no vegetariana (si/no)?");
        respuesta1 = Console.ReadLine();

        if (respuesta1 == "si")
        {
            Console.WriteLine("INGREDIENTES: ");
            Console.WriteLine("1. Pimiento:");
            Console.WriteLine("2.Tofu:");


        }
        else if (respuesta1 == "no")
        {
            Console.WriteLine("INGREDIENTES: ");
            Console.WriteLine("1. peperoni: ");
            Console.WriteLine("2. jamon: ");
            Console.WriteLine("3. salmon: ");
        }

        
             
        if (respuesta1 == "si")
            Console.WriteLine();
            Console.WriteLine("\n¿Escoga un ingrediente?: ");
        {
            int ingrediente1;

        
            ingrediente1 = int.Parse(Console.ReadLine());

            if (ingrediente1 == 1)
            {
                Console.WriteLine("Pimineto");
                Console.WriteLine("USTED ELEGIO PIZZA VEGETARIANA");

            }
            if (ingrediente1 == 2)
            {
                Console.WriteLine("tofu");
                Console.WriteLine("USTED ELEGIO PIZZA VEGETARIANA");

                
            }

            
            







        }
    }
}