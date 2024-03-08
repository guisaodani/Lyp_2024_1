internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n*********¡Pizzería Bella Napoli!*****************");

        Console.WriteLine("¡Bienvenido!");

        //preguntar tipo pizza
        Console.WriteLine("Quiere pizza vegetarina o no vegetariana? escriba (si/no) ");
        string resp1=Console.ReadLine();

        if (resp1 == "si")
        {
            Console.WriteLine("Ingredientes para la pizza vegetariana:");
            Console.WriteLine("1. Pimiento");
            Console.WriteLine("2. Tofu");
        }
        else if (resp1 == "no")
        {
            Console.WriteLine("Ingredientes para la pizza no vegetariana:");
            Console.WriteLine("1. Peperoni");
            Console.WriteLine("2. Jamón");
            Console.WriteLine("3. Salmón");
        }
        else { Console.WriteLine("Vuelva a ingresar al menu");return; }

        
        {
            //solicitar los ingredientes
            Console.WriteLine("Escriba o ingrese su ingrediente: ");
            string ingrediente1 = Console.ReadLine();

            Console.WriteLine("Su pizza es: ");

            if (ingrediente1 == "pimiento"||ingrediente1=="tofu") { Console.WriteLine($"pizza con mozzarella,tomate y {ingrediente1}");Console.WriteLine("Pizza vegetariana"); } 
            
            else if (ingrediente1=="jamon"||ingrediente1=="peperoni"||ingrediente1=="salmon") { Console.WriteLine($"pizza con mozzarella,tomate y {ingrediente1}");Console.WriteLine("Pizza no vegetariana"); }  
            

            
        }

       
        

    }

 }