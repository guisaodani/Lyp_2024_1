internal class Program
{
    private static void Main(string[] args)
    {
        //8.	Construir un programa que pida un número y luego diga si este número es par o no.

        //variables
        int num, operacion;
        
       

        Console.Write("\nINGRESE UN NUMERO PARA SABER SI ES PAR O IMPAR");

        Console.WriteLine("\nIngrese un numero: ");
        num = Convert.ToInt32(Console.ReadLine());
        operacion = num % 2;



        if (operacion == 0)
        {
            Console.WriteLine(string.Format("El numero es par"));
        } 
        else 
        {
            Console.WriteLine("El numero es impar");
        }





        


        
        
       





    }
}