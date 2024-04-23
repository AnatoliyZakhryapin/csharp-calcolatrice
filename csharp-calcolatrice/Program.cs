namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = CalcoliHelper.Somma(53, -100);
            //Console.WriteLine(x);

            //double y = CalcoliHelper.Somma(-53.11, 100.25);
            //Console.WriteLine(y);

            //int x = CalcoliHelper.Sottrazione(-53, -100);
            //Console.WriteLine(x);

            //double y = CalcoliHelper.Sottrazione(-22.33, 100.22);
            //Console.WriteLine(y);

            //int x = CalcoliHelper.Moltiplicazione(-53, -100);
            //Console.WriteLine(x);

            //double y = CalcoliHelper.Moltiplicazione(-22.33, 100.22);
            //Console.WriteLine(y);

            //int x = CalcoliHelper.ValoreAssoluto(-53);
            //Console.WriteLine(x);

            //double y = CalcoliHelper.ValoreAssoluto(-11.22);
            //Console.WriteLine(y);

            //int x = CalcoliHelper.Min(-53, 100);
            //Console.WriteLine(x);

            //double y = CalcoliHelper.Min(53.01, 100.01);
            //Console.WriteLine(y);

            //int x = CalcoliHelper.Max(-53, 100);
            //Console.WriteLine(x);

            //double y = CalcoliHelper.Max(53.01, 100.01);
            //Console.WriteLine(y);

            Console.WriteLine("Somma di 5 e 3: " + CalcoliHelper.Somma(5, 3));
            Console.WriteLine("Somma di 3.5 e 2.5: " + CalcoliHelper.Somma(3.5, 2.5));
            Console.WriteLine("Differenza tra -7 e 3: " + CalcoliHelper.Sottrazione(-7, 3));
            Console.WriteLine("Differenza tra 4.5 e 2.3: " + CalcoliHelper.Sottrazione(4.5, 2.3));
            Console.WriteLine("Moltiplicazione di -4 e 5: " + CalcoliHelper.Moltiplicazione(-4, 5));
            Console.WriteLine("Moltiplicazione di 2.5 e 3.5: " + CalcoliHelper.Moltiplicazione(2.5, 3.5));
            Console.WriteLine("Valore assoluto di -8: " + CalcoliHelper.ValoreAssoluto(-8));
            Console.WriteLine("Valore assoluto di -3.5: " + CalcoliHelper.ValoreAssoluto(-3.5));
            Console.WriteLine("Minimo tra 10 e 7: " + CalcoliHelper.Min(10, 7));
            Console.WriteLine("Minimo tra 2.5 e -3.5: " + CalcoliHelper.Min(2.5, -3.5));
            Console.WriteLine("Massimo tra 20 e 15: " + CalcoliHelper.Max(20, 15));
            Console.WriteLine("Massimo tra 7.8 e 9.1: " + CalcoliHelper.Max(7.8, 9.1));
        }
    }
}
