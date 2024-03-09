internal class Program
{
    private static void Main(string[] args)
    {
        //primero el salario de la persona, con una variable salario e inicializo de una vez

        Console.WriteLine("Ingrese el salario base:$XXXX");
        double salario = double.Parse(Console.ReadLine());

        //comision
        double comision = (0.10);

        //ventas de la persona las almaceno en una variable ventas1,ventas2 y venta3 
        // debes ingresar el valor de las ventas

        Console.WriteLine("Ingrese el valor de la venta 1:");
        double venta1= double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de la venta 2:");
        double venta2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de la venta 3:");
        double venta3 = double.Parse(Console.ReadLine());

        //¿Cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el  mes ? 

        double comisionporventa = ((venta1*comision)+(venta2*comision)+(venta3*comision));
        Console.WriteLine($" La comision del mes por las tres ventas es: {comisionporventa}");

        // ¿Cuál es el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones?

        double sueldomascomision = (salario + comisionporventa);
        Console.WriteLine($"El total que recibirá mas la comision es de: {sueldomascomision}");

        // ¿Cuál fue la venta que le generó la mayor comisión?

        Console.WriteLine("¿Cuál fue la venta que le generó la mayor comisión?");


        double comision1 = venta1*comision;
        double comision2 = venta2*comision;
        double comision3 = venta3*comision;

        if ((comision1 > comision2) && (comision1 > comision3)) { Console.WriteLine($"Mayor comision es de la venta :{venta1}"); }
        if ((comision2 > comision3) && (comision2 > comision1)) { Console.WriteLine($"Mayor comision es de la venta: {venta2}"); }
        if ((comision3 > comision2) && (comision3 > comision1)) { Console.WriteLine($"Mayor comision es de la venta: {venta3}"); }

        Console.WriteLine(" ¿Cuál fue el promedio de las comisiones que recibió por cada venta?");

       
            Console.WriteLine($"Promedio de las comisiones es: {(comision1+comision2+comision3)/3}");

        //Además, la empresa da un beneficio extra de $100.000 si el vendedor supera el objetivo del mes. El
        //objetivo es sumar en las 3 ventas como mínimo $1.000.000 en ventas. Mostrar un mensaje donde
        //indique si ganó o no el beneficio.

        double extra = 100000;
        double meta = 1000000;
        double totalventas = venta1 + venta2 + venta3;
        if (totalventas >= meta)
        {
            Console.WriteLine($"La persona ganó el beneficio de: {extra}");
        }

        

        


       
       













    }
}