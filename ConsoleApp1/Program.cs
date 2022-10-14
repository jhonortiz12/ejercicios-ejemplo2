namespace trabaj
{
    internal class program
    {
        static void Main()
        {
            int altura;
            int bbase;
            int altura_2;
            double A1;
            double A2;
            double AR;
            Console.WriteLine(" por favor dijite la atura");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine(" por favor dijite la base");
            bbase = int.Parse(Console.ReadLine());
            Console.WriteLine(" por favor dijite la atura de c");
            altura_2 = int.Parse(Console.ReadLine());
            A1 = bbase * altura_2;
            A2 = ((altura - altura_2) * bbase )/ 2;
            AR = A1 + A2;
            Console.WriteLine(" el area total del lote  es de " + AR);


        }
    }
}