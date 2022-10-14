namespace sueldo
{
   internal class program
    {
        static void Main()
        {
            double sueldo, hora, sueldototal;
            Console.WriteLine("por favor ingrese el numero de horas que trabajo en la semana ");
            hora = double.Parse(Console.ReadLine());
            Console.WriteLine("por favor ingrese el valor de la hora  ");
            sueldo = double.Parse(Console.ReadLine());
            sueldototal = hora * sueldo;
            Console.WriteLine("el sueldo total que recibe en la semana es de " + sueldototal );
        }
    }
}