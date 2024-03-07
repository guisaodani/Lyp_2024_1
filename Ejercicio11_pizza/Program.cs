internal class Program
{
    private static void Main(string[] args)
    {
        //11.	La pizzería Bella Napoli ofrece pizzas vegetarianas y no vegetarianas a sus clientes.
        //Los ingredientes para cada tipo de pizza aparecen a continuación.
        //•	Ingredientes vegetarianos: Pimiento y tofu.
        //•	Ingredientes no vegetarianos: Peperoni, Jamón y Salmón.
        //Escribir un programa en C# que pregunte al usuario si quiere una pizza vegetariana 	
        //o no, y en función de su respuesta le muestre un menú con los ingredientes 		
        //disponibles para que elija. Solo se puede elegir un ingrediente además de la 		
        //mozzarella y el tomate que están en todas las pizzas. Al final se debe mostrar por 	
        //pantalla si la pizza elegida es vegetariana o no y todos los ingredientes que lleva.
        Console.WriteLine("********PIZZERIA BELLA NAPOLI*******");

        // Preguntar al usuario si quiere una pizza vegetariana o no
        double pregunta1,pregunta2;

        Console.WriteLine("\n¿Quieres pizza Vegetariana?: 1 para SI 2 para NO ");
        pregunta1 = double.Parse(Console.ReadLine());


        if (pregunta1 == 1)

        {
            Console.WriteLine("INGREDIENTES: ");
            Console.WriteLine("1. Pimiento (+ tomate y mozarella) ");
            Console.WriteLine("2. Tofu: (+ tomate y mozarella) ");
        }
        else if (pregunta1 == 2)
        {
            Console.WriteLine("INGREDIENTES: ");
            Console.WriteLine("1. Peperoni (+ tomate y mozarella) ");
            Console.WriteLine("2. Jamon (+ tomate y mozarella) ");
            Console.WriteLine("3. Salmon (+ tomate y mozarella) ");
        }

        if (pregunta1==1)
        { 
        Console.WriteLine("Marque 1 para pimiento o 2 para tofu");
            pregunta2 = double.Parse(Console.ReadLine());
            if((pregunta2 == 1)||(pregunta2==2))
            {
                Console.WriteLine("Escogiste una pizza vegetariana");
            }

        }
        else if(pregunta1==2) 
        { 
        Console.WriteLine("Marque 1. para peperoni, 2 para jamon o 3 para salmon");
            pregunta2= double.Parse(Console.ReadLine());
            if((pregunta2 == 1)||( pregunta2==2)||(pregunta2==3))
            {
                Console.WriteLine("usted elegió pizza no vegetariana");
            }
        }

















    }

}
