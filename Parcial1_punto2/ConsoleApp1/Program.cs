internal class Program
{
    private static void Main(string[] args)
    {
        //Un tren sale de la estación “A” a las 10:00 AM y viaja a una velocidad constante de 80 km/h. Un
        //segundo tren sale de la misma estación a las 11:00 AM y viaja en la misma dirección a una velocidad
        //constante de 100 km / h. ¿A qué hora el segundo tren alcanzará al primer tren? Mostrar esta hora en pantalla
        Console.WriteLine("PUNTO 2 TREN");



        //Distancia=Velocidad×Tiempo
        //tren 1 ya recorrió una hora


        double tiempotren1 = 1;//1hora 0 60min
        double velocidadtren1 = 80;


        double distanciatren1 = (velocidadtren1 * (tiempotren1));



        double tiempotren2;
        double velocidadtren2 = 100;//km/h

        double distanciatren2 = (velocidadtren2 * 1);
        //la formula para determinar el tiempo que tarde el tren2 en alcanzar al 1 esta dada por donde t=tiempo
        // 80t+60=110t
        //luego despejando t

        double tiempo = (distanciatren1 + distanciatren2) / 100;
        Console.WriteLine($"El tiempo es: {tiempo} horas");


    }
}