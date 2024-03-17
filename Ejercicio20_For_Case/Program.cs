internal class Program
{
    private static void Main(string[] args)
    {
        //20.	Realice un programa que solicite dos números, luego debe pedirse un número que seleccionará alguna operación aritmética desde un menú. Si introduce 1 los números se deben sumar, si introduce 2 los números se deben restar, si es 3 los números se multiplican y si introduce 4 los números se dividen (validar división por cero). Independientemente de la selección, imprima el resultado. Además, el programa debe tener la posibilidad de volver al menú para pedir 2 nuevos números y hacer la elección de la operación aritmética o digitar cero para finalizar el programa.

        Double num1, num2,suma,resta,producto,cociente;
        int option;
        bool exit =false; // flag para volver o salir del programa
              
        do
        {   
            Console.Clear();
            Console.WriteLine("Ingrese el primer numero:");
            num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("\n|**********MENU DE OPERACIONES ARITMETICAS*********|");
            Console.WriteLine(" Seleccione un operacion aritmetica para sus numero ");
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine("|1.Suma                                            |");
            Console.WriteLine("|2.Resta                                           |");
            Console.WriteLine("|3.Producto                                        |");
            Console.WriteLine("|4.Cociente                                        |");
            Console.WriteLine("|0.Para salir                                      |");
            Console.WriteLine("|--------------------------------------------------|\n");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)

            {    
                case 0:
                    exit = true;
                    break;
                case 1:
                    suma = num1 + num2;
                    Console.WriteLine($"La suma de {num1}+{num2}={suma}");
                    Console.ReadKey(); //para sostener el programa
                    break;
                    
                case 2:
                    resta = num1 - num2;
                    Console.WriteLine($"La resta de {num1}-{num2}={resta}");
                    Console.ReadKey(); //para sostener el programa
                    break;
                    
                case 3:
                    producto = num1 * num2;
                    Console.WriteLine($"El producto de {num1}*{num2}={producto}");
                    Console.ReadKey(); //para sostener el programa
                    break;                   

                case 4:
                    if (num2 != 0)
                    {
                        cociente = num1 / num2;
                        Console.WriteLine($"El cociente de {num1}/{num2}={cociente}");
                        Console.ReadKey(); //para sostener el programa
                    }

                    else 
                    { 
                        Console.WriteLine("No se puede dividir por cero");
                        Console.ReadKey(); //para sostener el programa
                    }
                    
                    break;


                default:
                    Console.WriteLine($"La opcion {option} no es valida, ingrese un numero del menu");
                    Console.ReadKey(); //para sostener el programa
                    break;
            }                  

        }
        while (!exit);
                              
    }
}