using System;

namespace ListaPOOex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo;

            triangulo = new Triangulo();

            Console.Write("Informe a base do triangulo: ");
            triangulo.setBase(int.Parse(Console.ReadLine()));

            Console.Write("Informe a altura do triangulo: ");
            triangulo.setAltura(int.Parse(Console.ReadLine()));

            triangulo.calcularArea();

            Console.WriteLine("A area do triangulo é {0} ", triangulo.getArea());
        }
    }

}
