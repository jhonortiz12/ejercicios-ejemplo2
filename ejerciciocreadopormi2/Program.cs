namespace tela
{
    internal class program
    {
        static void Main()
        {
            double pulgadas, metros, telafinal;
            Console.WriteLine(" escrib la cantidad de tela que necesita en  cantidad de metros ");
            metros = double.Parse (Console.ReadLine());
            pulgadas = metros / 0.0254;
            Console.WriteLine(" la tela total que necesita en pulgadas es de  " + pulgadas);

        }
    }
}