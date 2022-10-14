namespace metroscubicos
{
    internal class program
    {
        static void Main()
        {
            double lado, valortotal, volumen , precio, metros; 

            Console.WriteLine("ingrese el vaor del lado ");
            lado = double.Parse(Console.ReadLine());
            volumen = lado * lado * lado;
            metros = volumen / 0.01;
            Console.WriteLine("el volumen total del cubo es de " + metros);
            Console.WriteLine("ingrese el precio total de cada metro ");
            precio = double.Parse(Console.ReadLine());
            valortotal = metros * precio;
            Console.WriteLine("el valor a total a paar es de  " + valortotal);

        }
    }
}
