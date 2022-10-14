namespace ejerciciodeleche
{
    internal class program
    {
        static void Main()
        {
            double litros, galon , precio, valorfinal;
            Console.WriteLine("ingrese la cantidad de litros que produjo el dia de hoy ");
            litros = double.Parse (Console.ReadLine());
            galon = litros / 3.785;
            Console.WriteLine("el valor de los litros producidos en galones es de  " + galon);
            Console.WriteLine("ingrese el precio del galon ");
            precio = double.Parse (Console.ReadLine());
            valorfinal = galon * precio;

            Console.WriteLine("el valor de la venta de leche el dia de hoy es de  " + valorfinal );  
        }
    }
}
   