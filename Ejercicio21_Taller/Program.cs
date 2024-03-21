using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        /* 21.Se quiere crear un algoritmo en C# que calcule el IMC de N pacientes y luego lo clasifique dentro de una categoría:

      -Si el IMC del paciente es menor a 18,5, entonces tiene peso insuficiente.
      -Si el IMC está entre 18,5 y 24,9 se encuentre en la categoría de Peso Saludable
      -Si el IMC está entre 25,0 y 29,9 entonces tiene sobrepeso
      - Si el IMC es mayor de 29.9 entonces tiene obesidad.

       Mostrar en pantalla la categoría de cada uno de los pacientes.La aplicación debe estar en capacidad de pedirle al usuario si quiere volver a calcular */

        //IMC=peso/estaturá al cuadrado

        Double estatura, peso, imc;

        Console.WriteLine("*****************INDICE DE MASA CORPORAL***********************");
        Console.WriteLine(" ");
        Console.WriteLine("Ingrese los siguientes datos");
        estatura = Convert.ToInt32(Console.ReadLine());
        peso = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("...");
        imc = peso / Math.Pow(estatura, 2);




    }
}