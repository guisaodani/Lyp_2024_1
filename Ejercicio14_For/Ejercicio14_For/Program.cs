internal class Program
{
    private static void Main(string[] args)
    {
        //14.	Programe un algoritmo que pida a usuario 2 números por pantalla y que muestre todos los números comprendidos entre ambos números incluyéndolos.
        int num1,num2,numMenor=0, numMayor=0;

        Console.WriteLine("Ingrese numero 1: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese numero 2: ");
        num2 = int.Parse(Console.ReadLine());

        if (num1>num2)
        {
            numMenor = num2;
            numMayor = num1;
        }
        else
        {
            numMenor = num1;
            numMayor = num2;

        }
        Console.Write("\n");

        for (int i = numMenor; i <= numMayor; i++)
        {
            Console.Write(i+ " ");
        }

    }
}